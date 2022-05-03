using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.Demo
{
    public static class Demo
    {
        public static void DemoObject()
        {
            Person person = new Person()
            {
                Name = "Mario",
                LastName = "Rossi",
                DateOfBirth = new DateTime(2000, 5, 5)
            };
            Console.WriteLine(person.ToString());
            //EQUIVALENTE A
            Console.WriteLine(person);

            
            Person person2 = person;

            if (person.Equals(person2))
            {
                Console.WriteLine("Le due persone sono uguali");
            }
            else
            {
                Console.WriteLine("Stiamo parlando di due persone diverse");
            }

            Person person3 = new Person()
            {
                Name = "Mario",
                LastName = "Rossini",
                DateOfBirth = new DateTime(2000, 5, 5)
            };

            if (person.Equals(person3))
            {
                Console.WriteLine("Persone uguali");
            }
            else
            {
                Console.WriteLine("Persone diverse");
            }

            Console.Clear();

            Document docArmani = new Document()
            {
                Type = "Passaporto",
                Number = "AB45424"
            };

            Person p = new Person()
            {
                Name = "Giorgio",
                LastName = "Armani",
                DateOfBirth = new DateTime(1950, 5, 3),
                Document = docArmani
            };

            Console.WriteLine($"Il vero Giorgio Armani -> {p}");

            //Person copiaArmani = p.ShallowCopy();

            //Clonazione profonda dell'oggetto p
            Person copiaArmani = p.DeepCopy();
            p.Document.Type = "Patente";
            p.Name = "Giorgio JR";
            Console.WriteLine("Dopo la modifica...");
            Console.WriteLine($"Il vero Giorgio Armani (dopo la modifica) -> {p}");
            Console.WriteLine($"Il clone di Giorgio Armani -> {copiaArmani}");

            Console.Clear();

            Person employee = new Employee()
            {
                Company = "Avanade",
                DateOfBirth= new DateTime(1980, 4, 5)
            };
            //Person employee = new Person();
            var emp = employee as Employee; //CAST da Person a Employee
            Console.WriteLine(emp.CalculateSalary());
            Console.WriteLine(employee);
            
        }

    }
}
