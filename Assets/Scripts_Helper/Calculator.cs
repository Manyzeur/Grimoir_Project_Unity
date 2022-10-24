using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private int _a = 0;
    [SerializeField] private int _b = 0;
    [SerializeField] private int _c = 0;


    void Start()
    {
        int res = Add(_a, _b =+ _c);
        
    }

    void Update()
    {
        

    }

    private int Add(int a, int b)
    {
        int res = a + b;
        return res;

    }
}