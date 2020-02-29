using System.Threading.Tasks;
using Orleans;
using TestOrleans.GrainInterfaces;

namespace TestOrleans.Grains
{
    public class CalculatorGrain : Grain,ICalculatorGrain
    {
        public Task<int> Add(int int1, int int2)
        {
            return Task.FromResult(int1 + int2);
        }
    }
}