using UnityEngine;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using Random = UnityEngine.Random;

public class CarsManager : MonoBehaviour
{
    [SerializeField] 
    private Mesh _mesh;

    [SerializeField] 
    private Material _material;

    [SerializeField] 
    private int _count = 10000;

    [SerializeField] 
    private float _rightSide, _leftSide, _frontSide, _backSide, _speed;

    [SerializeField] 
    private Information _information;

    private void Start()
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        // Create entity achetype
        var entityArchetype = entityManager.CreateArchetype(
            typeof(CarSpeed),
            typeof(Translation),
            typeof(LocalToWorld),
            typeof(RenderMesh),
            typeof(RenderBounds));
        var entityArray = new NativeArray<Entity>(_count, Allocator.Temp);
        
        // Create entities
        entityManager.CreateEntity(entityArchetype, entityArray);
        for (int i = 0; i < entityArray.Length; i++)
        {
            var entity = entityArray[i];
            entityManager.SetComponentData(entity, new CarSpeed { SpeedValue = 1f });
            entityManager.SetComponentData(entity, new Translation { Value = new float3(Random.Range(_rightSide, _leftSide), 0, Random.Range(_frontSide, _backSide)) });

            entityManager.SetSharedComponentData(entity, new RenderMesh
            {
                mesh = _mesh,
                material = _material
            });
        }

        entityArray.Dispose();
        _information.CarCounts = _count;
    }
}
