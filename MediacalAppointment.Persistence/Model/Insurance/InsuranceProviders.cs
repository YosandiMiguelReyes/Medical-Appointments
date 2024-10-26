

namespace MediacalAppointment.Persistence.Model.Insurance
{
    public class InsuranceProviders
    {
        public int InsuranceProvidersID { get; set; }
        public string ProviderName { get; set; }
        public string NetWorkName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string CustomerSupportContact { get; set; }
        public string AcceptedRegions { get; set; }
        public bool IsActive { get; set; }
    }
}
