using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.ChainOfResponsibility.Handler
{
    public class TigerHandler : AbstractHandler
    {
        public override string Handle(string richiesta)
        {
            if (richiesta == "Pizza")
                return $"Sono una tigre esigente, mangio solo {richiesta}!";
            return 
                base.Handle(richiesta);
        }
    }
}
