using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Date_Base_Query_Examples.DateBaseFolder
{
    internal class DateBase
    {
        


      

        

        public  List<QueryClass> ComonBase()
        {
            List<QueryClass> list = new List<QueryClass>()
            {
                new QueryClass()
                    {
                        LastName = "Jo'rajon",
                        FirstName = "Hoshimov",
                        Age = 20,
                        Salary = 250000,
                        Email = "jurajonov12@gmail.com",
                        Login = "dasndkjann3kj2nk",
                        Password = "1234qwerty"

                    },

                new QueryClass()
                    {
                        LastName = "Abdusamad",
                        FirstName = "Asadov",
                        Age = 15,
                        Salary = 150000,
                        Email = "samadov@gmail.com",
                        Login = "samadov_1",
                        Password = "12345"

                    },

                new QueryClass()
                    {
                        LastName = "Muhammadabdulloh",
                        FirstName = "Komilov",
                        Age = 21,
                        Salary = 8000000,
                        Email = "komilov@gmail.com",
                        Login = "Komilov_No1",
                        Password = "543210"

                    },

                new QueryClass()
                    {
                        LastName = "Shavqatjon",
                        FirstName = "Jo'rayev",
                        Age = 45,
                        Salary = 1000000,
                        Email = "shavqatov@gmail.com",
                        Login = "dabdala_1",
                        Password = "1230454sda"

                    },
                new QueryClass()
                    {
                        LastName = "Boburjon",
                        FirstName = "berdiyev",
                        Age = 30,
                        Salary = 230121,
                        Email = "berdiyev@gmail.com",
                        Login = "ovoldi_1",
                        Password = "1sda"

                    } 
            
            };
            return list;
        }


    }
}
