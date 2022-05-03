using AcademyF.Week2.EsercitazioneDesignPattern.Entities;
using AcademyF.Week2.EsercitazioneDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Test
{
    public class FactoryTest
    {
        [Fact]
        public void ShouldCreateNullCompanyWithNegativeEmployees()
        {
            //Mi aspetto che non venga creata nessuna tipologia di azienda
            //se il numero di dipendenti è inferiore a 0

            //ARRANGE

            //Dichiaro una variabile con il numero dipendenti
            int numeroDipendenti = -4;

            //Creo il componente che sarà in grado di creare la mia company
            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //Richiamo il metodo di creazione della nostra azienda
            ICompany company = factoryCompany.CreateCompany(numeroDipendenti);

            //ASSERT
            Assert.Null(company);
        }

        [Fact]
        public void ShouldCreateSmallCompanyWithTenEmployees()
        {
            //Mi aspetto la creazione di un'azienda di piccole dimensioni nel caso in cui
            //il numero di dipendenti sia pari a 10

            //ARRANGE

            //Dichiaro una variabile con il numero dipendenti
            int numeroDipendenti = 10;

            //Creo il componente che sarà in grado di creare la mia company
            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //Richiamo il metodo di creazione della nostra azienda
            ICompany smallCompany = factoryCompany.CreateCompany(numeroDipendenti);

            //ASSERT
            Assert.Equal("SmallCompany", smallCompany.GetType().Name);
        }

        [Fact]
        public void ShouldCreateMediumCompanyWithFiftyEmployees()
        {
            //Mi aspetto la creazione di un'azienda di medie dimensioni nel caso in cui
            //il numero di dipendenti sia pari a 50

            //ARRANGE

            //Dichiaro una variabile con il numero dipendenti
            int numeroDipendenti = 50;

            //Creo il componente che sarà in grado di creare la mia company
            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //Richiamo il metodo di creazione della nostra azienda
            ICompany mediumCompany = factoryCompany.CreateCompany(numeroDipendenti);

            //ASSERT
            Assert.Equal("MediumCompany", mediumCompany.GetType().Name);
        }
        [Fact]
        public void ShouldCreateBigCompanyWithFiftyEmployees()
        {
            //Mi aspetto la creazione di un'azienda di medie dimensioni nel caso in cui
            //il numero di dipendenti sia pari a 250

            //ARRANGE

            //Dichiaro una variabile con il numero dipendenti
            int numeroDipendenti = 250;

            //Creo il componente che sarà in grado di creare la mia company
            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //Richiamo il metodo di creazione della nostra azienda
            ICompany bigCompany = factoryCompany.CreateCompany(numeroDipendenti);

            //ASSERT
            Assert.Equal("BigCompany", bigCompany.GetType().Name);
        }
        [Fact]
        public void ShouldCreateMultinazionaleWithFiftyEmployees()
        {
            //Mi aspetto la creazione di un'azienda di medie dimensioni nel caso in cui
            //il numero di dipendenti sia pari a 600

            //ARRANGE

            //Dichiaro una variabile con il numero dipendenti
            int numeroDipendenti = 600;

            //Creo il componente che sarà in grado di creare la mia company
            FactoryCompany factoryCompany = new FactoryCompany();

            //ACT

            //Richiamo il metodo di creazione della nostra azienda
            ICompany multinazionaleCompany = factoryCompany.CreateCompany(numeroDipendenti);

            //ASSERT
            Assert.Equal("MultinazionaleCompany", multinazionaleCompany.GetType().Name);
        }

    }
}
