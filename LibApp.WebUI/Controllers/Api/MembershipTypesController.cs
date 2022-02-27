﻿using AutoMapper;
using LibApp.Application.Core.Contracts.Persistence;
using LibApp.Application.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.WebUI.Controllers.Api
{
    public class MembershipTypesController : BaseApiController
    {
        private readonly IMembershipTypeRepository _membershipTypeRepository;
        public MembershipTypesController(IMapper mapper, IMembershipTypeRepository membershipTypeRepository): base(mapper)
        {
            _membershipTypeRepository = membershipTypeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembershipTypes()
        {
            var entities = await _membershipTypeRepository.BrowseAsync();
            if (!entities.Any())
                return Ok(new List<MembershipTypeDto>());
            var genres = Mapper.Map<List<MembershipTypeDto>>(entities);
            return Ok(genres);
        }
    }
}
