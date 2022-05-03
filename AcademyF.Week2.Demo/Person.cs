using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Demo
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Document Document { get; set; }

        public override string ToString()
        {
            return $"{Name} - {LastName} - {DateOfBirth} \n {Document}";
        }

        public override bool Equals(object obj)
        {
            //Dal momento che obj può essere una classe qualsiasi verifico che obj non sia nullo
            //e che il tipo dell'oggetto passato sia uguale a Person
            if(obj == null || !GetType().Equals(obj.GetType())){
                return false;
            }
            else
            {
                Person p = (Person)obj;
                return Name.Equals(p.Name) && LastName.Equals(p.LastName) && DateOfBirth.Equals(p.DateOfBirth);
            }
        }

        public Person ShallowCopy()
        {
            //return (Person)MemberwiseClone();
            //EQUIVALENTE A
            return MemberwiseClone() as Person;
        }

        //Questo metodo esegue la clonazione profonda dell'oggetto Person
        public Person DeepCopy()
        {
            Person clone = MemberwiseClone() as Person;
            clone.Document = new Document()
            {
                Number = Document.Number,
                Type = Document.Type,
            };
            return clone;
        }
    }
}
