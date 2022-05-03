using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.ChainOfResponsibility.Handler
{
    public class LionHandler : AbstractHandler
    {
        public override string Handle(string richiesta)
        {
            if (richiesta == "Bistecca")
                return $"Sono un leone, amo la {richiesta}";
            else
                return base.Handle(richiesta);
        }
    }
}
