using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletSpawn : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform _bulletContainer = null;
    [SerializeField] private GameObject[] _bullet = null;
    [SerializeField] private Transform _bulletPosition = null;
    [SerializeField] private TMP_InputField _inputField = null;
    [SerializeField] private Animator _animation = null;
    #endregion
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

        if(s == "WIND")
        {
            Instantiate(_bullet[2], _bulletPosition.position, Quaternion.identity, _bulletContainer);
            _animation.SetTrigger("Fire");

        }


        _inputField.text = string.Empty;

    }

}
