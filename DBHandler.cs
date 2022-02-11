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
                    Console.WriteLine("Data Not Inserted ");
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
                    Console.WriteLine("Data Not Inserted ");
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
        public override void SelectByCityORState(String location)
        {
            SqlConnection connection = GetDBConnection();
           // String queary = "select * from address_book";
            try
            {
                using (connection)
                {
                    AddressBookModel model = new AddressBookModel();    
                    SqlCommand command = new SqlCommand("InsertContactsToAddressBook", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("city", location);
                    command.Parameters.AddWithValue("state", location);
                    command.Parameters.AddWithValue("stmnt", "Select");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count ++;
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString());
                            
                        }
                        Console.WriteLine(count+ " Person From "+location);
                    }
                    else
                    {
                        Console.WriteLine("No Data Found..");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
