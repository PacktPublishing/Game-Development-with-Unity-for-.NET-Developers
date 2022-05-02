using Unity.Entities;

public class SampleSystem : SystemBase
{
    protected override void OnUpdate()
    {
        var deltaTime = Time.DeltaTime;
        Entities.ForEach((ref SampleComponent sample) =>
        {
            sample.Value = -1;
        }).
        ScheduleParallel();
    }
}