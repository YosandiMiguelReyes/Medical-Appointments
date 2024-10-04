

namespace MediacalAppointment.Domain.Results
{
    public class OperationResult<T> where T : class
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
