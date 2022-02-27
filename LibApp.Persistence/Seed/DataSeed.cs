using LibApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Domain.Enums;

namespace LibApp.Persistence.Seed
{
    public class DataSeed : IDataSeed
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Customer> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public DataSeed(ApplicationDbContext context,
            UserManager<Customer> userManager,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task CreateUserWithRoles()
        {
            if (!_context.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>
                {
                    Name = RoleEnum.User.ToString(),
                    NormalizedName = RoleEnum.User.ToString()
                });

                await _roleManager.CreateAsync(new IdentityRole<int>
                {
                    Name = RoleEnum.StoreManager.ToString(),
                    NormalizedName = RoleEnum.StoreManager.ToString()
                });

                await _roleManager.CreateAsync(new IdentityRole<int>
                {
                    Name = RoleEnum.Owner.ToString(),
                    NormalizedName = RoleEnum.Owner.ToString()
                });
            }

            if (!_context.Users.Any())
            {
                var _user = new Customer
                {
                    Name = "David User Profile",
                    HasNewsletterSubscribed = true,
                    MembershipTypeId = 1,
                    Birthdate = new DateTime(1992, 06, 06),
                    UserName = "davidUser",
                    Email = "david.user@mail.com",
                    EmailConfirmed = true
                };

                var _manager = new Customer
                {
                    Name = "David Manager Profile",
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 2,
                    Birthdate = new DateTime(1997, 07, 07),
                    UserName = "davidManager",
                    Email = "david.manager@mail.com",
                    EmailConfirmed = true
                };

                var _owner = new Customer
                {
                    Name = "David Owner Profile",
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 4,
                    Birthdate = new DateTime(1999, 06, 06),
                    UserName = "davidOwner",
                    Email = "david.owner@mail.com",
                    EmailConfirmed = true
                };

                await _userManager.CreateAsync(_user, "haslo1234");
                await _userManager.CreateAsync(_manager, "haslo1234");
                await _userManager.CreateAsync(_owner, "haslo1234");
                await _userManager.AddToRoleAsync(_user, RoleEnum.User.ToString());
                await _userManager.AddToRoleAsync(_manager, RoleEnum.StoreManager.ToString());
                await _userManager.AddToRoleAsync(_owner, RoleEnum.Owner.ToString());
            }
        }

        public async Task InitializeGenre()
        {
            if (_context.Genre.Any())
                return;

            var genres = new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Web development"
                },
                new Genre
                {
                    Id = 2,
                     Name = "Cybersecruity"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Web"
                }
            };

            _context.Genre.AddRange(genres);
            await _context.SaveChangesAsync();
        }

        private async Task InitializeMembershipTypes()
        {
            if (_context.MembershipTypes.Any())
                return;
            var membershipTypes = new List<MembershipType>
            {
                  new MembershipType
                    {
                        Id = 1,
                        Name = "Pay as You Go",
                        SignUpFee = 0,
                        DurationInMonths = 0,
                        DiscountRate = 0
                    },
                    new MembershipType
                    {
                        Id = 2,
                        Name = "Monthly",
                        SignUpFee = 30,
                        DurationInMonths = 1,
                        DiscountRate = 10
                    },
                    new MembershipType
                    {
                        Id = 3,
                        Name = "Quaterly",
                        SignUpFee = 90,
                        DurationInMonths = 3,
                        DiscountRate = 15
                    },
                    new MembershipType
                    {
                        Id = 4,
                        Name = "Yearly",
                        SignUpFee = 300,
                        DurationInMonths = 12,
                        DiscountRate = 20
                    }
            };

            await _context.MembershipTypes.AddRangeAsync(membershipTypes);
            await _context.SaveChangesAsync();
        }

        private async Task InitializeBooks()
        {
            if (_context.Books.Any())
                return;

            var books = new List<Book>
            {
                new Book
                    {
                        Name="React. Zrób to sam!",
                        AuthorName="Jan Nowak, Stefan Kowalski",
                        GenreId = 1,
                        DateAdded = DateTime.Now,
                        ReleaseDate = new DateTime(2022, 02, 22),
                        NumberInStock = 4,
                        NumberAvailable = 4
                    },
                new Book
                    {
                        Name="Matematyka dla informatyków.",
                        AuthorName="Joseph Bridge",
                        GenreId = 2,
                        DateAdded = DateTime.Now,
                        ReleaseDate = new DateTime(2021, 04, 13),
                        NumberInStock = 2,
                        NumberAvailable = 2
                    },
                new Book
                    {
                        Name="React Native",
                        AuthorName="Simon Land",
                        GenreId = 2,
                        DateAdded = DateTime.Now,
                        ReleaseDate = new DateTime(2021, 12, 18),
                        NumberInStock = 30,
                        NumberAvailable = 30
                    },
            };
            await _context.Books.AddRangeAsync(books);
            await _context.SaveChangesAsync();
        }

        public async Task Initialize()
        {
            await InitializeMembershipTypes();
            await CreateUserWithRoles();
            await InitializeGenre();
            await InitializeBooks();
        }
    }
}
