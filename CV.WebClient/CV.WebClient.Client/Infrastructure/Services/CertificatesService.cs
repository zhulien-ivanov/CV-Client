namespace CV.WebClient.Client.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    using Newtonsoft.Json;

    using CV.Common.ViewModels.Certificate;

    using CV.WebClient.Client.Infrastructure.Contracts;

    public class CertificatesService : ICertificatesService
    {
        private const string BASE_ADDRESS = "http://cv-api.apphb.com/";
        private HttpClient httpClient;

        public CertificatesService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_ADDRESS);
        }

        public IEnumerable<CertificateViewModel> GetAll()
        {
            HttpResponseMessage response = this.httpClient.GetAsync("api/certificates").Result;

            IEnumerable<CertificateViewModel> certificates = null;

            if (response.IsSuccessStatusCode)
            {
                certificates = JsonConvert.DeserializeObject<IEnumerable<CertificateViewModel>>(response.Content.ReadAsStringAsync().Result);
            }

            return certificates;
        }
    }
}