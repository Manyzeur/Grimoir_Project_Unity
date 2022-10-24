using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    #region Attributs
    [SerializeField] private Transform[] _posCharacter = null;
    [SerializeField] private int _index = 1;
    #endregion Attributs
    #region Start / Update
    void Start()
    {
        transform.position = _posCharacter[1].position;
    }
    void Update()
    {
       Moving();
    }
    #endregion Start / Update

    private void Moving()
    {
        bool moveUp = Input.GetKeyDown(KeyCode.Z);
        bool moveDown = Input.GetKeyDown(KeyCode.S);
        

        if (moveDown && _index < _posCharacter.Length)
        {
            _index++;
            transform.position = _posCharacter[_index].position;
            Debug.Log("DOWN");
        }

        if( moveUp && _index > 0)
        {
            _index--;
            transform.position = _posCharacter[_index].position;
            Debug.Log("UP");
        }
    }
}
