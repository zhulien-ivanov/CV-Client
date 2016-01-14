namespace CV.WebClient.Client.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    using Newtonsoft.Json;

    using CV.Common.ViewModels;

    using CV.WebClient.Client.Infrastructure.Contracts;

    public class LanguageFrameworkService : ILanguageFrameworkService
    {
        private const string BASE_ADDRESS = "http://cv-api.apphb.com/";
        private HttpClient httpClient;

        public LanguageFrameworkService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_ADDRESS);
        }

        public IEnumerable<LanguageFrameworkDetailedViewModel> GetAll()
        {
            HttpResponseMessage response = this.httpClient.GetAsync("api/frameworks").Result;

            IEnumerable<LanguageFrameworkDetailedViewModel> frameworks = null;

            if (response.IsSuccessStatusCode)
            {
                frameworks = JsonConvert.DeserializeObject<IEnumerable<LanguageFrameworkDetailedViewModel>>(response.Content.ReadAsStringAsync().Result);
            }

            return frameworks;
        }

        public IEnumerable<LanguageFrameworkIconViewModel> GetAllByPartialViewModel()
        {
            HttpResponseMessage response = this.httpClient.GetAsync("api/frameworks/partial").Result;

            IEnumerable<LanguageFrameworkIconViewModel> frameworks = null;

            if (response.IsSuccessStatusCode)
            {
                frameworks = JsonConvert.DeserializeObject<IEnumerable<LanguageFrameworkIconViewModel>>(response.Content.ReadAsStringAsync().Result);
            }

            return frameworks;
        }

        public LanguageFrameworkDetailedViewModel GetById(int id)
        {
            LanguageFrameworkDetailedViewModel framework = null;

            HttpResponseMessage response = this.httpClient.GetAsync("api/frameworks/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                framework = JsonConvert.DeserializeObject<LanguageFrameworkDetailedViewModel>(response.Content.ReadAsStringAsync().Result);
            }

            return framework;
        }

        public IEnumerable<LanguageFrameworkDetailedViewModel> GetByLanguage(int id)
        {
            HttpResponseMessage response = this.httpClient.GetAsync("api/frameworks/bylang/" + id).Result;

            IEnumerable<LanguageFrameworkDetailedViewModel> frameworks = null;

            if (response.IsSuccessStatusCode)
            {
                frameworks = JsonConvert.DeserializeObject<IEnumerable<LanguageFrameworkDetailedViewModel>>(response.Content.ReadAsStringAsync().Result);
            }

            return frameworks;
        }

        public IEnumerable<LanguageFrameworkIconViewModel> GetByLanguagePartialViewModel(int id)
        {
            HttpResponseMessage response = this.httpClient.GetAsync("api/frameworks/bylang/" + id + "/partial").Result;

            IEnumerable<LanguageFrameworkIconViewModel> frameworks = null;

            if (response.IsSuccessStatusCode)
            {
                frameworks = JsonConvert.DeserializeObject<IEnumerable<LanguageFrameworkIconViewModel>>(response.Content.ReadAsStringAsync().Result);
            }

            return frameworks;
        }
    }
}