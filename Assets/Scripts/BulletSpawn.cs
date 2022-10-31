using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField] private Transform _bulletContainer = null;
    [SerializeField] private GameObject[] _bullet;
    [SerializeField] private Transform _bulletPosition = null;
    [SerializeField] private TMP_InputField _inputField = null;
    [SerializeField] private Animator _animation = null;
 


    void Start()
    {
        
    }


    void Update()
    {
        Spawnning();
        
    }

    private void Spawnning()
    {
        //bool inputFire = Input.GetKeyDown(KeyCode.F);
        //bool inputWater = Input.GetKeyDown(KeyCode.W);
        //bool inputAir = Input.GetKeyDown(KeyCode.A);

        /*if (inputFire)
        {
            Debug.Log("FIRE BULLET");
            Instantiate(_bullet[0], _bulletPosition.position, Quaternion.identity, _bulletContainer);
        }

        if (inputWater)
        {
            Debug.Log("WATER BULLET");
            Instantiate(_bullet[1], _bulletPosition.position, Quaternion.identity, _bulletContainer);
        }

        if (inputAir)
        {
            Debug.Log("AIR BULLET");
            Instantiate(_bullet[2], _bulletPosition.position, Quaternion.identity, _bulletContainer);
        }*/

    }

    public void OnReadString(string s)
    {
        s = s.ToUpper();
       

        if (s == "FIRE")
        {
            Instantiate(_bullet[0], _bulletPosition.position, Quaternion.identity, _bulletContainer);
            _animation.SetTrigger("Fire");

        }



        if(s == "WATER") 
        {
            Instantiate(_bullet[1], _bulletPosition.position, Quaternion.identity, _bulletContainer);
            _animation.SetTrigger("Fire");


        }

        if(s == "AIR")
        {
            Instantiate(_bullet[2], _bulletPosition.position, Quaternion.identity, _bulletContainer);
            _animation.SetTrigger("Fire");

        }


        _inputField.text = string.Empty;

    }

}
