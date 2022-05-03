using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Decorator
{
    public class EmployeeCarCompany : EmployeeDecorator
    {
        public string NrTarga { get; set; }
        public string Modello { get; set; }

        public EmployeeCarCompany(Employee employee, string nrTarga, string modello) : base(employee)
        {

            NrTarga = nrTarga;
            Modello = modello;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{NrTarga} {Modello}";
        }
    }
}
