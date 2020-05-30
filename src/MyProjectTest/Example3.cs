using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class Example3A
    {
        private readonly ITestOutputHelper _output;

        public Example3A(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestLong()
        {
            _output.WriteLine("Example3A: TestLong started");
            Thread.Sleep(6000);
        }

        [Fact]
        public void TestMedium()
        {
            _output.WriteLine("Example3A: TestLong started");
            Thread.Sleep(4000);
        }

        [Fact]
        public void TestSmall()
        {
            _output.WriteLine("Example3A: TestLong started");
            Thread.Sleep(2000);
        }
    }

    public class Example3B
    {
        private readonly ITestOutputHelper _output;

        public Example3B(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestLong()
        {
            _output.WriteLine("Example3B: TestLong started");
            Thread.Sleep(6000);
        }

        [Fact]
        public void TestMedium()
        {
            _output.WriteLine("Example3B: TestLong started");
            Thread.Sleep(4000);
        }

        [Fact]
        public void TestSmall()
        {
            _output.WriteLine("Example3B: TestLong started");
            Thread.Sleep(2000);
        }
    }

    [Collection("Serial")]
    public class Example3C
    {
        private readonly ITestOutputHelper _output;

        public Example3C(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestMedium()
        {
            _output.WriteLine("Example3C: TestLong started");
            Thread.Sleep(13000);
        }
    }

    [Collection("Serial")]
    public class Example3D
    {
        private readonly ITestOutputHelper _output;

        public Example3D(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestMedium()
        {
            _output.WriteLine("Example3D: TestLong started");
            Thread.Sleep(4000);
        }
    }
}
