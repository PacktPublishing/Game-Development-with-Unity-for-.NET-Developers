using Unity.Jobs;
using Unity.Burst;

[BurstCompile]
public struct SampleJobWithBurst : IJobParallelFor
{
    public void Execute(int index)
    {
        throw new System.NotImplementedException();
    }
}
