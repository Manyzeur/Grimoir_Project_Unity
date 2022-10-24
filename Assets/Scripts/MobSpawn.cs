using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawn : MonoBehaviour
{
    [SerializeField] private Transform _mobContainer = null;
    [SerializeField] private float _duration = 2;
    [SerializeField] private Transform[] _spawnPos = null;
    [SerializeField] private GameObject[] _mob = null;

    private float _timeStamp = 0;

    void Start()
    {
        
    }


    void Update()
    {
        
        Spawnning();
        
    }

    private void Spawnning()
    {
        _timeStamp += Time.deltaTime;

        if (_timeStamp >= _duration)
        {
            int index = Random.Range(0, _spawnPos.Length);
            int indexMob = Random.Range(0, _mob.Length);
            Instantiate(_mob[indexMob], _spawnPos[index].position, Quaternion.identity, _mobContainer);

            _timeStamp = 0;
        }
    }
}
