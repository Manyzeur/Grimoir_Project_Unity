using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DeathZone : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverMenu = null;
    [SerializeField] private GameObject _inputField = null;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Marche");
        if (other.tag == "Mob")
        {
            _gameOverMenu.SetActive(true);
            _inputField.SetActive(false);
            Time.timeScale = 0;
            
            
        }
    }
}
