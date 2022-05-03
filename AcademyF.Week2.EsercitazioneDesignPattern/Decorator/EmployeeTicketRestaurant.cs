using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Decorator
{
    public class EmployeeTicketRestaurant : EmployeeDecorator
    {
        public string NrTessera { get; set; }

        public int NrTicketMensili { get; set; }
        public EmployeeTicketRestaurant(Employee employee, string nrTessera,int nrTicketMensili) : base(employee)
        {

            NrTessera = nrTessera;
            NrTicketMensili = nrTicketMensili;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{NrTessera}  {NrTicketMensili}";
        }
    }
}
