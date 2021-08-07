using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataObjects;
using System.Dynamic;
using System.Xml.Linq;
using System.Xml;

namespace DataAccess
{
    public class DAL
    {
        private string connectionString;
        private string table;


        public DAL (string ConnectionString, string Table)
        {
            connectionString = ConnectionString;
            table = Table;


        }

        public List<CustomerObject> getAllCustomerData()
        {
            //string queryString = "EXEC " + table;
            string queryString = "GetCustomersData";
            List<CustomerObject> customers = new List<CustomerObject>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string errorMsg;
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomerObject customer = new CustomerObject();
                            int i = 0;
                            //customer.CustomerID     = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            customer.CompanyName    = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.ContactName    = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.ContactTitle   = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.Address        = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.City           = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.Region         = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.PostalCode     = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.Country        = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.Phone          = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;
                            //customer.Fax            = reader.IsDBNull(i) ? string.Empty : reader.GetString(i); i++;

                            customers.Add(customer);
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        errorMsg = e.Message;
                        Console.WriteLine(errorMsg);
                        throw;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    errorMsg = e.Message;
                    Console.WriteLine(errorMsg);
                    throw;
                }
            }

            return customers;
        }

        public List<EmployeeObject> getAllEmployeeData()
        {
            string queryString = "GetEmployeesData";
            List<EmployeeObject> employees = new List<EmployeeObject>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string errorMsg;
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeObject employee = new EmployeeObject();

                            int i = 0;

                            //employee.EmployeeID       = reader.IsDBNull(i) ? 0            : reader.GetInt32    (i); i++;
                            employee.LastName         = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.FirstName        = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.Title            = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.TitleOfCourtesy  = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.BirthDate        = reader.IsDBNull(i) ? null         : reader.GetDateTime (i); i++;
                            //employee.HireDate         = reader.IsDBNull(i) ? null         : reader.GetDateTime (i); i++;
                            //employee.Address          = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.City             = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.Region           = reader.IsDBNull(i) ? string.Empty : reader.GetString   (i); i++;
                            //employee.PostalCode       = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //employee.Country          = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //employee.HomePhone        = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //employee.Salary           = reader.IsDBNull(i) ? 0            : reader.GetDecimal (i); i++;
                            //employee.Extension        = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //employee.Photo            = reader.IsDBNull(i) ? null         : reader.GetSqlBytes(i); i++;
                            //employee.Notes            = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //employee.ReportsTo        = reader.IsDBNull(i) ? 0            : reader.GetInt32   (i); i++;
                            //employee.PhotoPath        = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;

                            employees.Add(employee);
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        errorMsg = e.Message;
                        Console.WriteLine(errorMsg);
                        throw;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    errorMsg = e.Message;
                    Console.WriteLine(errorMsg);
                    throw;
                }
            }

            return employees;
        }

        public List<OrderObject> getAllOrderData()
        {
            string queryString = "GetOrdersData";
            List<OrderObject> orders = new List<OrderObject>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string errorMsg;
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            OrderObject order = new OrderObject();

                            int i = 0;
                            
                            order.OrderID           = reader.IsDBNull (i) ? 0            : reader.GetInt32   (i); i++;
                            //order.CustomerID        = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //order.EmployeeID        = reader.IsDBNull(i) ? 0            : reader.GetInt32   (i); i++;
                            //order.OrderDate         = reader.IsDBNull(i) ? DateTime.MinValue         : reader.GetDateTime(i); i++;
                            //order.RequiredDate      = reader.IsDBNull(i) ? DateTime.MinValue         : reader.GetDateTime(i); i++;
                            //order.ShippedDate       = reader.IsDBNull(i) ? DateTime.MinValue         : reader.GetDateTime(i); i++;
                            //order.ShipVia           = reader.IsDBNull(i) ? 0            : reader.GetInt32   (i); i++;
                            //order.Freight           = reader.IsDBNull(i) ? 0            : reader.GetDecimal (i); i++;
                            //order.ShipName          = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //order.ShipAddress       = reader.IsDBNull(i) ? string.Empty : reader.GetString  (i); i++;
                            //order.ShipCity          = reader.IsDBNull(i) ? string.Empty : reader.GetString (i); i++;
                            //order.ShipRegion        = reader.IsDBNull(i) ? string.Empty : reader.GetString (i); i++;
                            //order.ShipPostalCode    = reader.IsDBNull(i) ? string.Empty : reader.GetString (i); i++;
                            //order.ShipCountry       = reader.IsDBNull(i) ? string.Empty : reader.GetString (i); i++;

                            orders.Add(order);
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        errorMsg = e.Message;
                        Console.WriteLine(errorMsg);
                        throw;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    errorMsg = e.Message;
                    Console.WriteLine(errorMsg);
                    throw;
                }
            }

            return orders;
        }
    }
}
