using UnityEngine;
using UnityEngine.Jobs;
using Unity.Jobs;
using System.Collections.Generic;

public class JobsManager : MonoBehaviour
{
    [SerializeField] 
    private List<GameObject> _carPrefabs;
    [SerializeField] 
    private float _rightSide, _leftSide, _frontSide, _backSide, _speed;
    [SerializeField] 
    private Information _information;

    private TransformAccessArray _transArrays;
    private JobHandle _jobHandle;
    private MotionJob _motionJob;

    private void Start()
    {
        _transArrays = new TransformAccessArray(10000);
        _jobHandle = new JobHandle();
    }

    private void Update()
    {
        _jobHandle.Complete();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateCars(10000);
        }

        _motionJob = new MotionJob()
        {
            DeltaTime = Time.deltaTime,
            Speed = _speed,
            Direction = Vector3.forward
        };

        _jobHandle = _motionJob.Schedule(_transArrays);
    }

    private void CreateCars(int count)
    {
        _jobHandle.Complete();
        _transArrays.capacity = _transArrays.length + count;

        for (var i = 0; i < count; i++)
        {
            var posX = Random.Range(_rightSide, _leftSide);
            var posZ = Random.Range(_frontSide, _backSide);

            var pos = new Vector3(posX, 0f, posZ);
            var rot = Quaternion.Euler(0f, 0f, 0f);
            int index = Random.Range(0, _carPrefabs.Count);
            var carPrefab = _carPrefabs[index];
            var carInstance = Instantiate(carPrefab, pos, rot);
            _transArrays.Add(carInstance.transform);
        }
        _information.CarCounts = count;
    }
}
