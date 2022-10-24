using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletteMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2;

    void Start()
    {
        DestroyObjectDelayed();
    }

    
    void Update()
    {
        transform.position = transform.position + (transform.forward * _speed * Time.deltaTime);
    }

    private void DestroyObjectDelayed()
    {
        Destroy(gameObject, 3);
    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dead Bullet");

        if (other.tag == "Mob")
        {
            Debug.Log("Dead");
            Destroy(other.transform.parent.gameObject);
            Destroy(gameObject);
            
        }
    }

}
