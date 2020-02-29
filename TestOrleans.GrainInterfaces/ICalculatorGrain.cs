using System;
using System.Threading.Tasks;
using Orleans;

namespace TestOrleans.GrainInterfaces
{
    public interface ICalculatorGrain: IGrainWithIntegerKey
    {
        Task<int> Add(int int1, int int2);
    }
}