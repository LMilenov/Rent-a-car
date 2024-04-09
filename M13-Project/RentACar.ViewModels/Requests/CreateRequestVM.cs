

namespace RentACar.ViewModels.Requests
{
    public class CreateRequestVM
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string User { get; set; }

        public string RequestId  { get; set; }
    }
}
