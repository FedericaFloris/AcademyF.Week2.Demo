using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.ChainOfResponsibility.Handler
{
    public interface IHandler
    {
        //Metodo per settare l'anello successivo della catena
        IHandler SetNext(IHandler handler);
        //Metodo per gestire la richiesta
        string Handle(string richiesta);
    }
}
