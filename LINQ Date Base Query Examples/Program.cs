using System;
using System.Collections.Generic;
using System.Linq;
using LINQ_Date_Base_Query_Examples.DateBaseFolder;

namespace LINQ_Date_Base_Query_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateBase dateBase = new DateBase();

            var baseDate = dateBase.ComonBase();

            #region
            //List<QueryClass> Items = (
            //    from result in baseDate
            //    where result.Age > 40
            //    select result).ToList();
            #endregion


            var Items = baseDate.Where(result => result.FirstName.ToLower().Contains("k"));


            foreach (QueryClass item in Items)
            {
                Console.WriteLine("LastName: {0}\n" + "FirstName: {1}\n" + "Age: {2}\n" + "Salary: {3}\n" + "Email: {4}\n" + "Login: {5}\n" + "Password: {6}",
                    item.LastName, item.FirstName, item.Age, item.Salary, item.Email, item.Login, item.Password);
            }
        }
    }
}
