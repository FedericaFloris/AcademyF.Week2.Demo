using AcademyF.Week2.EsercitazioneDesignPattern.Entities;

namespace AcademyF.Week2.EsercitazioneDesignPattern.Chain
{
    public interface IHandler
    {
        double HandleRequest(Employee employee);
        IHandler SetNext(IHandler absenceHandler);
    }
}