using Orleans;

namespace Grains;

public interface ICounterGrain : IGrainWithStringKey
{
    Task<int> Increment();
    Task<int> GetCount();
}