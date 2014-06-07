namespace Core
{
  public class OrdersMonitoringSystem
  {
    private readonly CustomerApi _customerApi;
    private readonly DelivererApi _delivererApi;

    public OrdersMonitoringSystem(CustomerApi customerApi, DelivererApi delivererApi)
    {
      _customerApi = customerApi;
      _delivererApi = delivererApi;
    }

    public void Start()
    {
      // imagine this method initializes the APIs
      // and exposes them so that users can call them
    }
  }
}