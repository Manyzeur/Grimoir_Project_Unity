using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DeathZone : MonoBehaviour
{
    #region Attributs
    [SerializeField] private GameObject _gameOverMenu = null;
    [SerializeField] private GameObject _inputField = null;
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Mob")
        {
            _gameOverMenu.SetActive(true);
            _inputField.SetActive(false);
            Time.timeScale = 0;
            Cursor.visible = true;

        }
    }
}
