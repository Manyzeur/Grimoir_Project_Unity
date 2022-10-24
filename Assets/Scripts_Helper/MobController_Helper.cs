using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController_Helper : MonoBehaviour
{
     private Transform _target = null;
    [SerializeField] private float _speed = 100;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 dir = _target.position - transform.position;
        transform.position += dir.normalized * _speed * Time.deltaTime;
    }

    public void Init(Transform target)
    {
        _target = target;
    }
    
  
}
