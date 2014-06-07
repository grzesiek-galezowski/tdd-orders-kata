using Core;

namespace OrdersMonitoring
{
  internal class AppContainer
  {
    public OrdersMonitoringSystem Resolve()
    {
      var customerApi = new CustomerApi();
      var delivererApi = new DelivererApi();
      var system = new OrdersMonitoringSystem(customerApi, delivererApi);
      return system;
    }
  }
}