using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.ChainOfResponsibility.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual string Handle(string richiesta)
        {
            if (_nextHandler != null)
                //se il nextHandler è diverso da null vuol dire che c'è un componente
                //in grado di prendere in carico la richiesta, per cui gliela invio
                return _nextHandler.Handle(richiesta);
            else
                //la richiesta non può essere presa in carico da nessuno quindi cade nel vuoto
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
