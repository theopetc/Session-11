using CarServiceCenterLibrary;

namespace Session_11
{
    public class ServiceCenter
    {
        public List<Car> Cars { get; set; }
        public ServiceCenter()
        {
            Cars = new List<Car>();
        }
    }
}