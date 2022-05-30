using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfDemeter
{
    public class Employee
    {
        public string Name { get; set; }
        public Department WorkingDepartment { get; set; }
        public string Introduce()
        {
            //return $"I'm {Name}, Working at {WorkingDepartment} at {WorkingDepartment.Company.Name}";
            return $"I'm {Name}, Working at {WorkingDepartment} at {WorkingDepartment.GetCompanyName()}";
        }
        public string Something()
        {
            return "";
        }
    }
    public class Department
    {
        public Company Company { get; set; }
        public string GetCompanyName() => Company.Name;             //indirection - wrapper method
    }
    public class Company
    {
        public string Name { get; set; }
    }

}
