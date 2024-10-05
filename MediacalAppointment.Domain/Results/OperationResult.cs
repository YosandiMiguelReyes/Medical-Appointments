

namespace MediacalAppointment.Domain.Results
{
    public class OperationResult<TResult>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public TResult? Data { get; set; }
        public ICollection<TResult>? DataCollection { get; set; }
    }
}
