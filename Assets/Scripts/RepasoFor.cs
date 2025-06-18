using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    public int num1;
    public int num2;


    void Start()
    {
        // Escribir en consola los números enteros desde cero a 4
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }


        // Los números enteros entre 10 y 40 inclusive
        for (int i = 10; i <= 40;)
        {
            Debug.Log(i);
        }

        // Los números enteros entre dos números ingresados por Inspector
        for (int i = num1; i < num2; i++)
        {
            Debug.Log(i);
        }

        // Los números enteros desde 11 hasta 1, excepto el 3
        for (int i = 11; i > 0; i--)
        {
            if (i == 3)
            {
                continue;
            }
            Debug.Log(i);
        }
    }

    void Update()
    {

    }
}
