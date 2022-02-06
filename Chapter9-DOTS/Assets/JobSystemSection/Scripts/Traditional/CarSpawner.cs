using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] 
    private List<GameObject> _carPrefabs;

    [SerializeField] 
    private float _rightSide, _leftSide, _frontSide, _backSide;

    [SerializeField] 
    private Information _information;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateCars(10000);
        }
    }

    private void CreateCars(int count)
    {
        for(var i = 0; i < count; i++)
        {
            var posX = Random.Range(_rightSide, _leftSide);
            var posZ = Random.Range(_frontSide, _backSide);

            var pos = new Vector3(posX, 0f, posZ);
            var rot = Quaternion.Euler(0f, 0f, 0f);
            int index = Random.Range(0, _carPrefabs.Count);
            var carPrefab = _carPrefabs[index];
            var carInstance = Instantiate(carPrefab, pos, rot);
        }
        _information.CarCounts = count;
    }
}
