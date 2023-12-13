using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Text;
using System.Threading.Tasks;
using PartMng.Data.Dtos;
using PartMng.Data.Entities;

namespace PartMng.Data.Repositories
{
    public interface IPartsRepository
    {
        User GetUserByLogin(string login);

        User GetUserById(int id);

        IEnumerable<User> GetUsers();
        IEnumerable<Address> GetUsersAddress(int id);

        IEnumerable<Address> GetAllAddresses();

        IEnumerable<Orders> GetAllOrders();

        IEnumerable<Parts> GetAllParts();
        void AddUser(User user);
        void UpdateUser(User user);
        void AddPart(Parts part);
        void UpdatePart(Parts part);
        void AddOrder(User user, Parts part);
        void UpdateOrder(User user, Parts part);
        void Add(string name, string nip, string phoneNo, string email,
            string city, string street, string buildingNo, string postalCode, string country);
    }
}



