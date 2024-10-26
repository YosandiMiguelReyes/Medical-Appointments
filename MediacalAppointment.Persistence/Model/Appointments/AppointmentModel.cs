
namespace MediacalAppointment.Persistence.Model.Appointments
{
    public class AppointmentModel
    {
        public int AppointmentID { get; set; }
        public string DoctorName { get; set; }
        public string PacientName { get; set; }
        public string StatusName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
