using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Demo
{
    public class Document
    {
        public string Type { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"Document Type: {Type} - No. {Number}";
        }
    }
}
