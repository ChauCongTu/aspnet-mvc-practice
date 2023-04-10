using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_WebApplication2.Models
{
    internal interface ICustomerRepository
    {
        //Khai báo phương thức lấy danh sách khách hàng
        IList<Customer> GetCustomer();

        //Khai báo phương thức lấy khách hàng
        Customer GetCustomer(string customerId);

        //Khai báo phương thức thêm khách hàng
        void AddCustomer(Customer customer);

        //Khai báo phương thức cấp nhật khách hàng
        void UpdateCustomer(Customer customer);

        //Khai báo phương thức tìm kiếm khách hàng
        IList<Customer> SearchCustomer(string name);

        //Khai báo phương thức xóa khách hàng
        void DeleteCustomer(Customer customer);
    }
}
