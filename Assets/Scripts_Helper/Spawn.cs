using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private MobController_Helper _mob = null;
    [SerializeField] private Transform _mobContainer = null;
    [SerializeField] private float _duration = 2;
    [SerializeField] private Transform _mobTarget = null;

    [SerializeField] private Transform[] _spawnPos = null;
    [SerializeField] private List<int> _intList = null;    
   
    private float _timeStamp = 0;

    
    void Start()
    {
        DisplayList();
    }

    
    void Update()
    {
        // _timeStamp = _timeStamp + Time.deltaTime (c'est la même chose)
        _timeStamp += Time.deltaTime;

        if (_timeStamp >= _duration)
        {
            int index = Random.Range(0, _spawnPos.Length);
            //while (index < _spawnPos.Length)
            //(int i = 0; i < _spawnPos.Length; i++)
            //{
                //MobController mob = obj.GetComponent<MobController>(); (version crade et amène des bugs)
                MobController_Helper mob = Instantiate(_mob, _spawnPos[index].position, Quaternion.identity, _mobContainer);
                mob.Init(_mobTarget);
                //index++;

            //}
            
            
            _timeStamp = 0;
        }
        
    }

    private void DisplayList()
    {
        for(int i = 0; i < _intList.Count; i++)
        {   
            //Debug.Log(_intList[i]);
        }
    }
}
