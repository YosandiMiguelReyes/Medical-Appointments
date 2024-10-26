namespace MediacalAppointment.Persistence.Model.Users
{
    public class DoctorMoodule
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string SpecialityName { get; set; }
        public string LicenseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsExperience { get; set; }
        public decimal ConsultationFee { get; set; }
        public string ClinicAddress { get; set; }
        public int AvailabilityModeId { get; set; }
        public DateTime LicenseExpirationDate { get; set; }
    }
}
