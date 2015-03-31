using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetrixDistributed
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMetrixDistributedService" in both code and config file together.
    [ServiceContract]
    public interface IMetrixDistributedService
    {
        [OperationContract]
        void DoWork();

    }

    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        int CustomerSave(Customer customer);

        [OperationContract]
        int CustomerUpdate(Customer customer);

        [OperationContract]
        int CustomerDelete(Customer customer);

        [OperationContract]
        Customer CustomerSearch(int customerId);
    }

  
    [ServiceContract]
    public interface IEmployeeService
        {
            [OperationContract]
            int EmployeeSave(Employee employee);

            [OperationContract]
            int EmployeeUpdate(Employee employee);

            [OperationContract]
            int EmployeeDelete(Employee employee);

            [OperationContract]
            Employee EmployeeSearch(int employeeId);
        }

    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        int ProductSave(Product product);

        [OperationContract]
        int ProductUpdate(Product product);

        [OperationContract]
        int ProductDelete(Product product);

        [OperationContract]
        Product ProductSearch(int productId);
    }

    [ServiceContract]
    public interface ISupplierService
    {
        [OperationContract]
        int SupplierSave(Supplier supplier);

        [OperationContract]
        int SupplierUpdate(Supplier supplier);

        [OperationContract]
        int SupplierDelete(Supplier supplier);

        [OperationContract]
        Supplier SupplierSearch(int supplierId);
    }
}
