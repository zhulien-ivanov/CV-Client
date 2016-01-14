namespace CV.WebClient.Client.Infrastructure.Contracts
{
    using System.Collections.Generic;

    using CV.Common.ViewModels;

    public interface ILanguageFrameworkService
    {
        IEnumerable<LanguageFrameworkDetailedViewModel> GetAll();

        IEnumerable<LanguageFrameworkIconViewModel> GetAllByPartialViewModel();

        LanguageFrameworkDetailedViewModel GetById(int id);

        IEnumerable<LanguageFrameworkDetailedViewModel> GetByLanguage(int id);

        IEnumerable<LanguageFrameworkIconViewModel> GetByLanguagePartialViewModel(int id);
    }
}