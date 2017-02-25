using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Quanta.Tests
{
  public class TestClass
  {
    [Fact]
    public void Test()
    {
      Assert.Equal(2, 1 + 1);
    }
  }
}
