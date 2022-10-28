using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CharacterController : MonoBehaviour
{

    #region Attributs
    [SerializeField] private Transform[] _posCharacter = null;
    [SerializeField] private int _index = 1;
    [SerializeField] private TMP_InputField _InputField = null;

    #endregion Attributs
    #region Start / Update
    void Start()
    {
        transform.position = _posCharacter[1].position;
        _InputField.ActivateInputField();
    }
    void Update()
    {
       //Moving();
    }
    #endregion Start / Update

    /*private void Moving()
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

    }*/

    public void OnReadStringMoving(string s) 
    {
        s = s.ToUpper();

        if (s == "DOWN")
        {
            _index++;
            Debug.Log("DOWN");
        }

        if(s == "UP")
        {
            _index--;
            Debug.Log("UP");
        }

        _index = Mathf.Clamp(_index, 0, _posCharacter.Length - 1);
        transform.position = _posCharacter[_index].position;
        _InputField.text = string.Empty;
        _InputField.ActivateInputField();
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
