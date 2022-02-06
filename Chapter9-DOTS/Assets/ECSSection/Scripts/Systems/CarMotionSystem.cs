using Unity.Entities;
using Unity.Transforms;

public class CarMotionSystem : SystemBase
{
    protected override void OnUpdate()
    {
        var deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation translation, ref CarSpeed carSpeed) =>
        {
            translation.Value.z += carSpeed.SpeedValue * deltaTime;
        }).
        ScheduleParallel();
    }
}
