

namespace MediacalAppointment.Domain.Results
{
    public class OperationResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public dynamic Data { get; set; }
    }
}
