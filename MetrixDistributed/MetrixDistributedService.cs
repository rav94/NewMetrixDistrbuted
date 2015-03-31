using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using MySql.Data.MySqlClient;
using System.Text;
using System.Data;

namespace MetrixDistributed
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MetrixDistributedService" in both code and config file together.
    public class MetrixDistributedService : IMetrixDistributedService, ICustomerServices, IEmployeeServices, IProductServices, ISupplierServices
    {

        DatabaseConnection db;
        DataTable table;

        public int CustomerSave(Customer customer)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO customer VALUES('" + customer.cusIdValue + "','" + customer.cusNameValue + "','" + customer.cusContactValue + "', '" + customer.cusNicValue + "', '" + customer.cusAdLine1Value + "', '" + customer.cusAdLine2Value + "', '" + customer.cusAdLine3Value + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int CustomerUpdate(Customer customer)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE customer SET  Name='" + customer.cusNameValue + "', ContactNo='" + customer.cusContactValue + "', NICNo='" + customer.cusNicValue + "', AddressLine1='" + customer.cusAdLine1Value + "', AddressLine2='" + customer.cusAdLine2Value + "', AddressLine3='" + customer.cusAdLine3Value + "' WHERE CustomerId='" + customer.cusIdValue + "'";

            return new DatabaseConnection().Query(sql);
        }

        public int CustomerDelete(Customer customer)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "";

            return new DatabaseConnection().Query(sql);
        }

        public Customer CustomerSearch(int customerId)
        {
            Customer customer = new Customer();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM customer WHERE CustomerId = '" + customerId + "' ";
            DataTable table = db.SearchQuery(sql);
            customer.cusNameValue = table.Rows[0][1].ToString();
            customer.cusContactValue = table.Rows[0][3].ToString();
            customer.cusNicValue = table.Rows[0][2].ToString();
            customer.cusAdLine1Value = table.Rows[0][4].ToString();
            customer.cusAdLine2Value = table.Rows[0][5].ToString();
            customer.cusAdLine3Value = table.Rows[0][6].ToString();

            return customer;
        }

        public int EmployeeSave(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO employee VALUES('" + employee.empIdValue + "','" + employee.empNameValue + "','" + employee.empContactValue + "', '" + employee.empAdLine1Value + "', '" + employee.empAdLine2Value + "', '" + employee.empDobValue + "', '" + employee.empNicValue + "', '" + employee.empPosValue + "', '" + employee.empDeptValue + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int EmployeeUpdate(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE employee SET EmpName = '" + employee.empNameValue + "', ContactNo = '" + employee.empContactValue + "', AddressLine1 = '" + employee.empAdLine1Value + "', AddressLine2='" + employee.empAdLine2Value + "', DOB='" + employee.empDobValue + "', NICNo='" + employee.empNicValue + "', Position='" + employee.empPosValue + "', Department='" + employee.empDeptValue + "' WHERE EmpId='" + employee.empIdValue + "'   ";

            return new DatabaseConnection().Query(sql);
        }

        public int EmployeeDelete(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "";

            return new DatabaseConnection().Query(sql);
        }

        public Employee EmployeeSearch(int employeeId)
        {
            Employee employee = new Employee();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM employee WHERE EmpId = '" + employeeId + "'";
            DataTable table = db.SearchQuery(sql);
            employee.empNameValue = table.Rows[0][1].ToString();
            employee.empContactValue = table.Rows[0][2].ToString();
            employee.empAdLine1Value = table.Rows[0][3].ToString();
            employee.empAdLine2Value = table.Rows[0][4].ToString();
            employee.empDobValue = table.Rows[0][5].ToString();
            employee.empNicValue = table.Rows[0][6].ToString();
            employee.empPosValue = table.Rows[0][7].ToString();
            employee.empDeptValue = table.Rows[0][8].ToString();

            return employee;
        }

        public int ProductSave(Product product)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO product VALUES('" + product.prodIdValue + "','" + product.nameValue + "','" + product.brandValue + "', '" + product.countryValue + "', '" + product.supIdValue + "', '" + product.purchPriceValue + "', '" + product.salePriceValue + "', '" + product.warrentValue + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int ProductUpdate(Product product)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE product SET ProductName = '" + product.nameValue + "',  Brand= '" + product.brandValue + "', Country = '" + product.countryValue + "', SupplierId='" + product.supIdValue + "',PurchasePrice='" + product.purchPriceValue + "', SalesPrice='" + product.salePriceValue + "', Warrenty='" + product.warrentValue + "' WHERE productId='" + product.prodIdValue + "'   ";

            return new DatabaseConnection().Query(sql);
        }

        public int ProductDelete(Product product)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "";

            return new DatabaseConnection().Query(sql);
        }

        public Product ProductSearch(int productId)
        {
            Product product = new Product();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM product WHERE productId = '" + productId + "'";
            DataTable table = db.SearchQuery(sql);
            product.nameValue = table.Rows[0][1].ToString();
            product.brandValue = table.Rows[0][2].ToString();
            product.countryValue = table.Rows[0][3].ToString();
            product.supIdValue = Convert.ToInt16(table.Rows[0][4].ToString());
            product.purchPriceValue = Convert.ToInt16(table.Rows[0][5].ToString());
            product.salePriceValue = Convert.ToInt16(table.Rows[0][6].ToString());
            product.warrentValue = table.Rows[0][7].ToString();

            return product;
        }

        public int SupplierSave(Supplier supplier)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO supplier VALUES('" + supplier.supIdValue + "','" + supplier.companyNameValue + "','" + supplier.contactValue + "', '" + supplier.add + "', '" + supplier.countryValue + "', '" + supplier.emailValue + "', '" + supplier.refNameValue + "') ";

            return new DatabaseConnection().Query(sql);
        }

        public int SupplierUpdate(Supplier supplier)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE suplier SET CompanyName = '" + supplier.companyNameValue + "',  ContactNo= '" + supplier.contactValue + "', Address = '" + supplier.add + "', Country='" + supplier.countryValue + "',Email='" + supplier.emailValue + "', ReferenceName='" + supplier.refNameValue + "' ";

            return new DatabaseConnection().Query(sql);
        }

        public int SupplierDelete(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier SupplierSearch(int supplierId)
        {
            Supplier supplier = new Supplier();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM supplier WHERE SupplierId = '"+supplier.supIdValue+"'";
            DataTable table = db.SearchQuery(sql);
            supplier.companyNameValue = table.Rows[0][1].ToString();
            supplier.contactValue = table.Rows[0][2].ToString();
            supplier.add = table.Rows[0][3].ToString();
            supplier.countryValue = table.Rows[0][4].ToString();
            supplier.emailValue = table.Rows[0][5].ToString();
            supplier.refNameValue = table.Rows[0][6].ToString();

            return supplier;
        }

        
        
        
        
        
        
        
        
        
        
        //public int ForeignSupplierSave(ForeignSupplier fsupplier)
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    string sql = "INSERT INTO supplier VALUES('" + fsupplier.supIdValue + "','" + fsupplier.companyNameValue + "','" + fsupplier.contactValue + "', '" + fsupplier.add + "', '" + fsupplier.countryValue + "', '" + fsupplier.emailValue + "', '" + fsupplier.refNameValue + "') ";

        //    return new DatabaseConnection().Query(sql);
        //}

        //public int ForeignSupplierUpdate(ForeignSupplier fsupplier)
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    string sql = "UPDATE suplier SET CompanyName = '" + fsupplier.companyNameValue + "',  ContactNo= '" + fsupplier.contactValue + "', Address = '" + fsupplier.add + "', Country='" + fsupplier.countryValue + "',Email='" + fsupplier.emailValue + "', ReferenceName='" + fsupplier.refNameValue + "' ";

        //    return new DatabaseConnection().Query(sql);
        //}

        //public int ForeignSupplierDelete(ForeignSupplier fsupplier)
        //{
        //    throw new NotImplementedException();
        //}

        //public ForeignSupplier ForeignSupplierSearch(int supplierId)
        //{
        //    ForeignSupplier fsupplier = new ForeignSupplier();
        //    DatabaseConnection db = new DatabaseConnection();

        //    string sql = "SELECT * FROM supplier WHERE SupplierId = '"+fsupplier.supIdValue+"'";
        //    DataTable table = db.SearchQuery(sql);
        //    fsupplier.companyNameValue = table.Rows[0][1].ToString();
        //    fsupplier.contactValue = table.Rows[0][2].ToString();
        //    fsupplier.add = table.Rows[0][3].ToString();
        //    fsupplier.countryValue = table.Rows[0][4].ToString();
        //    fsupplier.emailValue = table.Rows[0][5].ToString();
        //    fsupplier.refNameValue = table.Rows[0][6].ToString();

        //    return fsupplier;

        //}
    }
}
