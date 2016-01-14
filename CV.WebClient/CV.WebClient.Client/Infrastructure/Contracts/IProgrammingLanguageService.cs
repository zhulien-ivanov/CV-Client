namespace CV.WebClient.Client.Infrastructure.Contracts
{
    using System.Collections.Generic;

    using CV.Common.ViewModels;

    public interface IProgrammingLanguageService
    {
        IEnumerable<ProgrammingLanguageDetailedViewModel> GetAll();

        IEnumerable<ProgrammingLanguageIconViewModel> GetAllByPartialViewModel();
        
        ProgrammingLanguageDetailedViewModel GetById(int id);
    }
}