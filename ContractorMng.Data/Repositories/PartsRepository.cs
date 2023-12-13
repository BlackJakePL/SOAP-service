using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PartMng.Data.Entities;

namespace PartMng.Data.Repositories
{
    public class PartsRepository : IPartsRepository
    {
        private readonly PartsContext _partsContext;

        public PartsRepository()
        {
            _partsContext = null;
        }

        public PartsRepository(PartsContext contractorContext)
        {
            _partsContext = contractorContext;
        }

        public User GetUserByLogin(string login)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Users
                    .Where(c=>c.Name.ToUpper() == login.ToUpper())
                    .FirstOrDefault();
            }
        }

        public User GetUserById(int id)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Users
                    .Where(c => c.UserId == id)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<User> GetUsers()
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Users.ToList();
            }
        }
        IEnumerable<Address> IPartsRepository.GetUsersAddress(int id)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Addresses.Where(x=> x.UserId==id).ToList();
            }
        }
        public IEnumerable<Address> GetAllAddresses()
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Addresses.ToList();
            }
        }
        public IEnumerable<Orders> GetAllOrders()
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Orders.ToList();
            }
        }
        public IEnumerable<Parts> GetAllParts()
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                return context.Parts.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
               context.Users.Add(user);
               context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                var usr = context.Users.Where(x => x.UserId == user.UserId).FirstOrDefault();
                usr = user;
                context.SaveChanges();
            }
        }

        public void AddPart(Parts part)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                context.Parts.Add(part);
                context.SaveChanges();
            }

        }
        public void UpdatePart(Parts part)
        {
            using (var context = _partsContext ?? new PartsContext())
            {
                var prt = context.Parts.Where(x => x.PartId == part.PartId).FirstOrDefault();
                prt = part;
                context.SaveChanges();
            }

        }
        public void AddOrder(User user, Parts part)
        {
            Orders order = new Orders(user, part);
            using (var context = _partsContext ?? new PartsContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        public void UpdateOrder(User user, Parts part)
        {
            Orders order = new Orders(user, part);
            using (var context = _partsContext ?? new PartsContext())
            {
                var ord = context.Orders.Where(x => x.OrderId == order.OrderId).FirstOrDefault();
                ord = order;
                context.SaveChanges();
            }
        }


        public void Add(string name, string nip, string phoneNo, string email,
            string city, string street, string buildingNo, string postalCode, string country)
        {
            using (var context = _partsContext ?? new PartsContext())
            {


                var mainAddress = new Address
                {
                    City = city,
                    Street = street,
                    BuildingNo = buildingNo,
                    Country = country
                };

              
                var user = new User
                {
                    Name = name,
                    Nip = nip,
                    PhoneNo = phoneNo,
                    Email = email
                };

                user.Addresses.Add(mainAddress);

                context.Users.Add(user);

                context.SaveChanges();
            }
        }

 
    }
}