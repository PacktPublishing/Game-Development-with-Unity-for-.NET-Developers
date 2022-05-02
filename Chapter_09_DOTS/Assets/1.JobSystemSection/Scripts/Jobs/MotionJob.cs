using Unity.Burst;
using UnityEngine;
using UnityEngine.Jobs;

[BurstCompile]
public struct MotionJob : IJobParallelForTransform
{
    public float Speed, DeltaTime;
    public Vector3 Direction;

    public void Execute(int index, TransformAccess transform)
    {
        transform.position += Direction * Speed * DeltaTime;
    }
}
