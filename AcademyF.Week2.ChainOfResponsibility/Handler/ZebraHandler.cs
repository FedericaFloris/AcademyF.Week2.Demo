using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.ChainOfResponsibility.Handler
{
    public class ZebraHandler : AbstractHandler
    {
        public override string Handle(string richiesta)
        {
            if (richiesta == "Insalata")
                return $"{richiesta} è il mio piatto preferito";
            return 
                base.Handle(richiesta);
        }
    }
}
