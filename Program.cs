using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDB
{
    internal class Program
    {
        public static void Main(String []args)
        {
            AddressBookModel model = new AddressBookModel();
            model.firstName = "sumit";
            model.lastName = "jadhav";
            model.address= "Pu-154";
            model.city = "pune";
            model.state = "mharashtra";  
            model.zip = "425001";
            model.mobileNo = "4567891230";
            model.email = "rohit665@gmail.com";

            DBConnector connector = new DBHandler();
            //----- Uc 3 -----

            // int flag=connector.Insert(model);

            //----- UC 4 ------

            // int flag = connector.Update(model, "rohit");

            //----- Uc5 -----

            int flag = connector.Delete("sumit");

        }
    }
}