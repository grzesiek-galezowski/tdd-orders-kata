using Xunit;

namespace CoreSpecification
{
  class DummySpecification
  {
    [Fact]
    public void ShouldFail()
    {
      Assert.True(false, "Temporary Statement just to make sure all the tools work");
    }
  }
}
