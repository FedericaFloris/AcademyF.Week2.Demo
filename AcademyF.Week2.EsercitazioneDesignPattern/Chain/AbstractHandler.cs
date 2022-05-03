using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Chain
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler { get; set; }
        public virtual double HandleRequest(Employee employee)
        {
            if(_nextHandler != null)
                return _nextHandler.HandleRequest(employee);
            return 0.0;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
