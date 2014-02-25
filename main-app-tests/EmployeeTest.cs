using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mainapp
{
    [TestClass]
    public class EmployeeTest
    {
        [TestCategory("Unit"), TestMethod]
        public void TestGetFirstName()
        {
            Employee employee = new Employee("Roger", "Rabbit");
            Assert.AreEqual("Roger", employee.GetFirstName(), "First name not correct");
        }

        [TestCategory("Unit"), TestCategory("Slow"), TestCategory("Acceptance"), TestMethod]
        public void TestGetLastName()
        {
            Employee employee = new Employee("Roger", "Rabbit");
            Assert.AreEqual("Rabbit", employee.GetLastName(), "Last name not correct");
        }

        [TestCategory("Unit"), TestCategory("Fast"), TestCategory("Integration"), TestMethod]
        public void TestEquality()
        {
            Employee employee = new Employee("John", "Kennedy");
            Employee employee2 = new Employee("John", "Kennedy");
            Assert.AreEqual(employee, employee2);
        }

        [TestCategory("Unit"), TestCategory("Security"), TestMethod]
        public void TestHashCode()
        {
            Employee employee = new Employee("John", "Kennedy");
            Employee employee2 = new Employee("John", "Kennedy");
            Assert.AreEqual(employee.GetHashCode(), employee2.GetHashCode());
        }

        [TestCategory("Unit"), TestMethod]
        public void TestToString()
        {
            Employee employee = new Employee("Johnn", "Kennedy");
            Assert.AreEqual(employee.ToString(), "Employee{John,Kennedy}");
        }

        [TestCategory("Unit"), TestMethod]
        public void TestFullName()
        {
            Employee employee = new Employee("Abe", "Lincoln");
            Assert.AreEqual(employee.GetFullName(), "Abe Lincoln");
        }

        /*Custom Unit Tests - Destrucitve Testing*/
        [TestCategory("Unit"), TestMethod]
        public void TestEqualityDesctructive()
        {
            Employee employee = new Employee("James", "Kirk");
            Employee employee2 = new Employee("Jean", "Picard");
            Assert.AreNotEqual(employee, employee2);
        }
    }
}
