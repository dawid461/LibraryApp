﻿using AutoMapper;
using LibApp.Application.Core.Dtos;
using LibApp.Application.Core.Exceptions;
using LibApp.Application.Core.Helpers;
using LibApp.Application.Core.Models;
using LibApp.Application.Core.Validators;
using LibApp.Application.Core.Validators.Customers;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibApp.Application.UseCases.Customers.Commands
{
    public static class CreateCustomer
    {
        public class Command : IRequest
        {
            public string Name { get; set; }
            public bool HasNewsletterSubscribed { get; set; }
            public byte MembershipTypeId { get; set; }
            public DateTime? Birthdate { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly string _endpoint = "/api/customers";
            private readonly ILogger<Handler> _logger;
            private readonly HttpClient _httpClient;
            private readonly IMapper _mapper;

            public Handler(ILogger<Handler> logger, IMapper mapper, IHttpClientFactory httpClientFactory)
            {
                _logger = logger;
                _mapper = mapper;
                _httpClient = httpClientFactory.CreateClient("APIClient");
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    var validator = new CreateCustomerValidator();
                    var validationResult = await validator.ValidateAsync(request);

                    if (!validationResult.IsValid)
                    {
                        var errors = validationResult.Errors
                        .Select(a => new ValidationError { Property = a.PropertyName, Message = a.ErrorMessage })
                        .ToList();
                        throw new ValidationException(errors, "The request is invalid.");         
                    }

                    var customerDto = _mapper.Map<CustomerDto>(request);
                    var content = new StringContent(
                        JsonConvert.SerializeObject(customerDto),
                        Encoding.UTF8,
                        "application/json");

                    var response = await _httpClient.PostAsync(_endpoint, content);

                    if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        var httpErrorObject = response.Content.ReadAsStringAsync().Result;
                        var validationErrors = HttpResponseHelpers.MapValidationErrors(response);
                        if (validationErrors.Any())
                            throw new ValidationException(validationErrors, "");
                        else
                            throw new Exception("An error has occured while creating a customer object."); 
                    }

                    return response.StatusCode == System.Net.HttpStatusCode.Created
                        ? Unit.Value
                        : throw new Exception("An error has occured while creating a customer object.");
                }
                catch (Exception exception)
                {
                    _logger.LogError(exception.Message, exception);
                    throw;
                }
            }
        }
    }
}
