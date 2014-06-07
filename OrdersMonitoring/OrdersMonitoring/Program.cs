namespace OrdersMonitoring
{
  static class Program
  {
    static void Main(string[] args)
    {
      var system = new AppContainer().Resolve();
      system.Start();
    }
  }
}
