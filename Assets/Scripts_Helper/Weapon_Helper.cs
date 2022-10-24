using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Helper : MonoBehaviour
{
    [SerializeField] private GameObject _bullet = null;
    [SerializeField] private Transform _spawnPoint = null;
    [SerializeField] private Transform _bulletContainer = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bullet, _spawnPoint.position, Quaternion.identity, _bulletContainer);
        }

 
    }





}
