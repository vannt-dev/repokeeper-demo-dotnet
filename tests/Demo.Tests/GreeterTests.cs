using Demo;
using Xunit;

namespace Demo.Tests;

public class GreeterTests
{
    [Fact]
    public void GreetsByName() => Assert.Equal("Hello, Ada!", Greeter.Greet("Ada"));
}
