namespace CV.WebClient.Client.Infrastructure.Contracts
{
    using System.Collections.Generic;

    using CV.Common.ViewModels.Certificate;

    public interface ICertificatesService
    {
        IEnumerable<CertificateViewModel> GetAll();
    }
}