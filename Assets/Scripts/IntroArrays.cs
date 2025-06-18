using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroArrays : MonoBehaviour
{
    public int[] edades;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < edades.Length; i++)
        {
            Debug.Log(edades[i]);
        }

        foreach (int edad in edades)
        {
            Debug.Log(edad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
