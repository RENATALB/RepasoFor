using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] carteles;
    public int randomNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(ActivateRandomElement), 0, 2f);  // Invocar la activación random cada 2 segundos
        InvokeRepeating(nameof(DeactivateAll), 2, 2f);
    }

    void DeactivateAll()
    {
        for (int i = 0; i < carteles.Length; i++)
        {
            carteles[i].SetActive(false);
        }
    }
    // Funcion que activa un elemento al azar del array
    // y desactiva todos los demás

    void ActivateRandomElement()
    {
        randomNumber = Random.Range(0, carteles.Length);
        carteles[randomNumber].SetActive(true);
    }
}
