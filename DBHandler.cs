using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDB
{
    internal class DBHandler : DBConnector
    {
       
        public override int Insert(AddressBookModel model)
        {
            SqlConnection connection = GetDBConnection();
            try
            {  
                if (model != null)
                {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand("InsertContactsToAddressBook", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("stmnt", "Insert");
                        command.Parameters.AddWithValue("firstName", model.firstName);
                        command.Parameters.AddWithValue("lastName", model.lastName);
                        command.Parameters.AddWithValue("address", model.address);
                        command.Parameters.AddWithValue("city", model.city);
                        command.Parameters.AddWithValue("state", model.state);
                        command.Parameters.AddWithValue("zip", model.zip);
                        command.Parameters.AddWithValue("mobileNo", model.mobileNo);
                        command.Parameters.AddWithValue("email", model.email);
                        connection.Open();
                        return command.ExecuteNonQuery();
                        Console.WriteLine("Data Inserted Successfully");
                    }
                }
                else
                {
                    Console.WriteLine("model is null ");
                    return 0;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }     
        }

        public override int Update(AddressBookModel model, String position)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                if (model != null)
                {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand("InsertContactsToAddressBook", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("stmnt", "Update");
                        command.Parameters.AddWithValue("position", position);
                        command.Parameters.AddWithValue("firstName", model.firstName);
                        command.Parameters.AddWithValue("lastName", model.lastName);
                        command.Parameters.AddWithValue("address", model.address);
                        command.Parameters.AddWithValue("city", model.city);
                        command.Parameters.AddWithValue("state", model.state);
                        command.Parameters.AddWithValue("zip", model.zip);
                        command.Parameters.AddWithValue("mobileNo", model.mobileNo);
                        command.Parameters.AddWithValue("email", model.email);
                        
                        connection.Open();
                        return command.ExecuteNonQuery();
                        Console.WriteLine("Data Update Successfully");
                    }
                }
                else
                {
                    Console.WriteLine("model is null ");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }
        public override int Delete(string position)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand("InsertContactsToAddressBook", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("stmnt", "Delete");
                        command.Parameters.AddWithValue("position", position);
                        connection.Open();
                        return command.ExecuteNonQuery();
                        Console.WriteLine("Data Delete Successfully");
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}
