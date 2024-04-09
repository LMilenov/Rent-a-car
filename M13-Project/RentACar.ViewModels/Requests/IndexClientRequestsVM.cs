
namespace RentACar.ViewModels.Requsts
{
    public class IndexClientRequestsVM:IndexRequestsVM
    {
       
        public IndexClientRequestsVM()
        {
            this.Requests = new List<IndexRequestVM>();
            this.Action = "IndexClient"; // Change action to "CreateSelectCar"
        }
    }
}
