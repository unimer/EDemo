
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyDB.DataAccess;
using DummyDB.Models;


namespace DummyDB.BusinessLogic
{
    class EmployeeProcessor
    {
        public static int CreateEmployee(string firstName, string lastName, string email, int team)
        {
            EmployeeModel data = new EmployeeModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = email,
                Team = team
            };

            string sql = @"insert into dbo.Employees(FirstName, LastName, EmailAddress, Team) values (@FirstName, @LastName, @EmailAddress, @Team);";

            return DataAccess.DataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select * from dbo.Employees;";
            return DataAccess.DataAccess.LoadData<EmployeeModel>(sql);    
        }
    }
}
