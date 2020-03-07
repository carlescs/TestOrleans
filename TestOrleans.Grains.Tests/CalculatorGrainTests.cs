using System.Threading.Tasks;
using Xunit;

namespace TestOrleans.Grains.Tests
{
    public class CalculatorGrainTests
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(1,-1,0)]
        [InlineData(int.MinValue,-1, int.MaxValue)]
        public async Task TestAdd(int i1, int i2, int r)
        {
            var calculator=new CalculatorGrain();
            var result = await calculator.Add(i1, i2);
            Assert.Equal(r,result);
        }
    }
}
