namespace CV.WebClient.Client.Infrastructure.Contracts
{
    using System.Collections.Generic;

    using CV.Common.ViewModels.ProgrammingLanguage;

    public interface IProgrammingLanguageService
    {
        IEnumerable<ProgrammingLanguageDetailedViewModel> GetAll();

        IEnumerable<ProgrammingLanguageIconViewModel> GetAllByPartialViewModel();
        
        ProgrammingLanguageDetailedViewModel GetById(int id);
    }
}