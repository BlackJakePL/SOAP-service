using System;
using System.Collections.Generic;
using System.Linq;
using PartMng.Data.Entities;
using PartMng.Data.Repositories;
using PartMng.Service.Contract;
using Address = PartMng.Service.Contract.Address;
using User = PartMng.Service.Contract.User;

namespace PartMng.Service
{
    public class PartService : IPartService
    {
        public User GetUserByLogin(string login)
        {
            IPartsRepository PartRepository = new PartsRepository();

            var user = PartRepository.GetUserByLogin(login);

            return GetUser(user);
        }

        public User GetUserById(int id)
        {
            IPartsRepository PartRepository = new PartsRepository();

            var user = PartRepository.GetUserById(id);

            return GetUser(user);
        }

        private User GetUser(Data.Entities.User user)
        {
            User result = null;

            if (user != null)
            {
                var address = user.Addresses.First();

                result = new User
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Nip = user.Nip,
                    Email = user.Email,
                    PhoneNo = user.PhoneNo
                };

                if (address != null)
                {
                    var temp = new Address();
                    temp.AddressId = address.AddressId;
                    temp.Street = address.Street;
                    temp.BuildingNo = address.BuildingNo;
                    temp.City = address.City;
                    temp.Country = address.Country;
                    result.Addresses = temp;
                }
            }

            return result;
        }

        public IEnumerable<User> GetUsers()
        {
            var result = new List<User>();
            IPartsRepository PartRepository = new PartsRepository();

            foreach (var contractor in PartRepository.GetUsers())
            {
                result.Add(new User
                {
                    UserId = contractor.UserId,
                    Name = contractor.Name,
                    Nip = contractor.Nip,
                    Email = contractor.Email,
                    PhoneNo = contractor.PhoneNo
                });
            }

            return result;
        }

        public IEnumerable<Address> GetAllAddresses(int id)
        {
            var result = new List<Address>();
            IPartsRepository PartRepository = new PartsRepository();

            foreach (var address in PartRepository.GetUsersAddress(id))
            {
                result.Add(new Address
                {
                    AddressId = address.AddressId,
                    City = address.City,
                    Street = address.Street,
                    BuildingNo = address.BuildingNo,
                    Country = address.Country
                });
            }

            return result;
        }

        public User GetContractorByName(string name)
        {
            throw new NotImplementedException();
        }

        public User GetContractorById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllContractors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAllContractorAddresses(int id)
        {
            throw new NotImplementedException();
        }

        public User AddContractor(string name, string nip, string phoneNo, string email, string city,
            string street, string buildingNo, string postalCode, string country)
        {
            IPartsRepository PartRepository = new PartsRepository();

            PartRepository.Add(name, nip, phoneNo, email, city,
                street, buildingNo, postalCode, country);

            //var contractor = PartRepository.GetUserByLogin();
            var user = new PartMng.Data.Entities.User();

            return GetUser(user);

        }

        
    }
}
