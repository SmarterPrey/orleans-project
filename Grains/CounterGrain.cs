using Orleans;

namespace Grains;

public class CounterGrain : Grain, ICounterGrain
{
    private int _count = 0;

    public Task<int> Increment()
    {
        _count++;
        return Task.FromResult(_count);
    }

    public Task<int> GetCount() => Task.FromResult(_count);
}