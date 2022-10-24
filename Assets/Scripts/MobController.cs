using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private EBulletTypes _bulletTypes = EBulletTypes.FIRE;

    public EBulletTypes BulletTypes
    {
        get
        {
            return (_bulletTypes);
        }
    }

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
        transform.position = transform.position - transform.right * _speed * Time.deltaTime;

    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 5);
    }
}
