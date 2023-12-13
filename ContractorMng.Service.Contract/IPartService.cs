using System.Collections.Generic;
using System.ServiceModel;

namespace PartMng.Service.Contract
{
    [ServiceContract]
    public interface IPartService
    {
        [OperationContract]
        User GetUserByLogin(string login);
        [OperationContract]
        User GetUserById(int id);
        [OperationContract]
        User LoginUser(string login, string Pass);  
        [OperationContract]
        IEnumerable<User> GetUsers();
        [OperationContract]
        IEnumerable<Address> GetUsersAddress(int id);
        [OperationContract]
        IEnumerable<Address> GetAllAddresses();
        [OperationContract]
        Address GetAddressById(int id);
        [OperationContract]
        IEnumerable<Order> GetAllOrders();
        [OperationContract]
        IEnumerable<Part> GetAllParts();
        [OperationContract]
        IEnumerable<Wholesaler> GetAllWholesalers();
        [OperationContract]
        void UpdateUser(int UserId, string Login, string Pass, string Name, string LastName, string Nip,
            string PhoneNo, string Email, int AddressId, bool IsAdmin = false);
        [OperationContract]
        void AddUser(string Login, string Pass, string Name, string LastName, string Nip,
            string PhoneNo, string Email,  string City, string Street, string BuildingNo, string Country, bool IsAdmin = false);
        [OperationContract]
        void AddPart(int WholesalerId, string Producer, string PartNo, string OemNo, double Price);

        [OperationContract]
        void UpdatePart(int PartId, int WholesalerId, string Producer, string PartNo, string OemNo, double Price);

        [OperationContract]
        void AddOrder(int UserId, int PartId, int AddressId, int Qty);
        [OperationContract]
        void AddAddress(int UserId, string City, string Street, string BuildingNo, string Country);
        [OperationContract]
        void AddWholesaler(int AddressId, string Name, string Nip);

    }
}
