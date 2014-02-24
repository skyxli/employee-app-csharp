using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * del testResults.trx

"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\MSTest.exe" /testcontainer:main-app-tests\bin\Release\main-app-tests.dll /category:"%categories%" /resultsFile:testResults.trx
*/

namespace mainapp
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }


        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Employee other = (Employee)obj;
            return (other.firstName == this.firstName) && (other.lastName == this.lastName);
        }

        public override int GetHashCode()
        {
            return (firstName.GetHashCode() + lastName.GetHashCode()) % 233;
        }

        public override string ToString()
        {
            return String.Format("Employee{{{0},{1}}}", firstName, lastName + " Moe Dee");
        }

        public object GetFullName()
        {
            return String.Format("{0} {1}", firstName, lastName);
        }
    }
}
