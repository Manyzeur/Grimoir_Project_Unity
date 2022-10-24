using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    #region Attributs
    [SerializeField] private float _speed = 5;
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _damageTake = 10;
    private int _currentHealth = 100;
    #endregion Attributs
    #region Properties
    public int CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        }
    }

    public int MaxHeath => _maxHealth;
    /*{
        get
        {
            return _maxHealth;
        }
    }*/
    #endregion Properties
    #region Start / Update
    void Start()
    {
        _currentHealth = _maxHealth;

    }

    void Update()
    {
        Move();
    }
    #endregion Start / Update
    #region Character Movements
    private void Move()
	{
        bool inputRight = Input.GetKey(KeyCode.D);
        bool inputLeft = Input.GetKey(KeyCode.Q);
        bool inputForward = Input.GetKey(KeyCode.Z);
        bool inputBack = Input.GetKey(KeyCode.S);
        bool inputTakeDamage = Input.GetKeyDown(KeyCode.F);


        if (inputRight)
		{
            transform.position = transform.position + transform.right * _speed * Time.deltaTime;
		}

        if(inputLeft)
        {
           transform.position = transform.position - transform.right * _speed * Time.deltaTime; 
        }

		if (inputForward)
		{
            transform.position = transform.position + transform.forward * _speed * Time.deltaTime;
		}

        if (inputBack)
		{
            transform.position = transform.position - transform.forward * _speed * Time.deltaTime;
		}
        

        if (inputTakeDamage)
        {
            TakeDamage(_damageTake);  
        }

    }
    #endregion Character Movements
    #region Methodes
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Mob")
        {
           
            Destroy(other.transform.parent.gameObject);
            TakeDamage(_damageTake);
            
        }

    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
         Debug.Log("Currente Health : " + _currentHealth + "!");

    }
    #endregion Methodes

}