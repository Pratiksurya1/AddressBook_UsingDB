using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace AddressBookUsingDB
{
    public abstract class DBConnector
    {
        public SqlConnection GetDBConnection()
        {         
            return new  SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True");
        }

        public abstract int Insert(AddressBookModel model);

        public abstract int Update(AddressBookModel model, String position);
        public abstract int Delete(String position);
        public abstract void SelectByCityORState(String location);
       
}
}
