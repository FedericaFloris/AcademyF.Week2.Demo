using AcademyF.Week2.EsercitazioneDesignPattern.Decorator;
using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Test
{
    public class DecoratorTest
    {
        [Fact]
        public void ShouldHaveEmployeeWithoutBenefit()
        {
            //Se un impiegato è un impiegato semplice mi aspetto che non abbia nessun tipo di 
            //benefit

            //ARRANGE
            Employee employee = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi"
            };

            //ACT
            string benefit = employee.ViewBenefit();

            //ASSERT
            //Mi aspetto che la stringa contentente i benefit sia vuota
            Assert.Equal("", benefit);
            Assert.True(string.IsNullOrEmpty(benefit));
        }


        [Fact]
        public void ShouldHaveCarParkingNotNullForEmployee()
        {
            //Per impiegati caratterizzati dal benefit posto auto voglio che
            //il codice del posto auto sia non nullo o diverso da stringa vuota

            //ARRANGE
            Employee employee = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi"
            };

            //Creo il componente in grado di arricchire l'impiegato con il benefit
            //posto auto
            employee = new EmployeeParkingCar(employee, "P3456");

            //ACT
            string benefit = employee.ViewBenefit();

            //ASSERT
            Assert.NotEqual("", benefit); //VALIDO MA NON PERFETTAMENTE COMPRENSIBILE
            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("P3456", benefit);
        }

        [Fact]
        public void ShouldHaveHealtyPolicyNullForEmployee()
        {
            //Per impiegati caratterizzati dal benefit assistenza sanitaria voglio che
            //il codice dell'assistenza sia non nullo o diverso da stringa vuota

            //ARRANGE
            Employee employee = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi"
            };

            //Creo il componente in grado di arricchire l'impiegato con il benefit
            //posto auto
            employee = new EmployeeHealthyPolicy(employee, "H123");

            //ACT
            string benefit = employee.ViewBenefit();

            //ASSERT
            Assert.NotEqual("", benefit); //VALIDO MA NON PERFETTAMENTE COMPRENSIBILE
            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("H123", benefit);
        }

        [Fact]
        public void ShouldHaveBothHealthyPolicyAndParkingCar()
        {
            //Per impiegati caratterizzati sia dal benefit assistenza sanitaria che posto auto
            //voglio che sia il codice dell'assistenza che quello del posto auto
            //sia non nullo o diverso da stringa vuota

            //ARRANGE
            //Creo come dipendente di partenza un dipendente che abbia il posto auto assegnato
            Employee employee = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi"
            };
            var employeeParkingCar = new EmployeeParkingCar(employee, "WE4889");

            //Creo il componente in grado di arricchire l'impiegato con il benefit
            //posto auto
            employee = new EmployeeHealthyPolicy(employeeParkingCar, "H123");

            //ACT
            string benefit = employee.ViewBenefit();

            //ASSERT
            Assert.NotEqual("", benefit); //VALIDO MA NON PERFETTAMENTE COMPRENSIBILE
            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("H123", benefit);
            Assert.Contains("WE4889", benefit);
        }

        [Fact]
        public void ShouldHaveTicketRestaurantNullForEmployee()
        {
            //Per impiegati caratterizzati dal benefit ticket restaurant voglio che
            //il codice dell'assistenza sia non nullo o diverso da stringa vuota

            //ARRANGE
            Employee employee = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi"
            };

            //Creo il componente in grado di arricchire l'impiegato con il benefit
            //posto auto
            employee = new EmployeeTicketRestaurant(employee, "CY778",8);

            //ACT
            string benefit = employee.ViewBenefit();

            //ASSERT
            Assert.NotEqual("", benefit); //VALIDO MA NON PERFETTAMENTE COMPRENSIBILE
            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("CY778", benefit);
            
            
        }
        [Fact]
        public void ShouldHaveCarCompanyNullForEmployee()
        {
            //Per impiegati caratterizzati dal benefit ticket restaurant voglio che
            //il codice dell'assistenza sia non nullo o diverso da stringa vuota

            //ARRANGE
            Employee employee = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi"
            };

            //Creo il componente in grado di arricchire l'impiegato con il benefit
            //posto auto
            employee = new EmployeeCarCompany(employee, "CY778", "Panda");

            //ACT
            string benefit = employee.ViewBenefit();

            //ASSERT
            Assert.NotEqual("", benefit); //VALIDO MA NON PERFETTAMENTE COMPRENSIBILE
            Assert.True(!string.IsNullOrEmpty(benefit));
            Assert.Contains("CY778", benefit);
            Assert.Contains("Panda", benefit);


        }
    }
}
