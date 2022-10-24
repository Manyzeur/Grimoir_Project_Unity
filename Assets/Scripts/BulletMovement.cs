using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private EBulletTypes _bulletTypes = EBulletTypes.FIRE;

    void Start()
    {
        
    }

    
    void Update()
    {
        Moving();
        DestroyObjectDelayed();
    }

    private void Moving()
    {
        transform.position = transform.position + transform.right * _speed * Time.deltaTime;
    }

    private void DestroyObjectDelayed()
    {
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Mob")
        {
            MobController mob = other.GetComponentInParent<MobController>();
            
            if (_bulletTypes == mob.BulletTypes )
            {
                Debug.Log("DEAD");
                Destroy(other.transform.parent.gameObject);
                Destroy(gameObject);
            }


        }


    }
}
