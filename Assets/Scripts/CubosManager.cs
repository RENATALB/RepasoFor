using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosManager : MonoBehaviour
{
    public CubeScript[] cubos;

    //// Start is called before the first frame update
    void Start()
    {
        cubos = FindObjectsOfType<CubeScript>();
        //    for (int i = 0; i < cubos.Length; i++)
        //    {
        //        if (!cubos[i].isPersistent)
        //        {
        //            Destroy(cubos[i].gameObject);
        //        }
        //    }
        //}

        // Posicionar todos los cubos en el cero del espacio

        //    for (int i = 0; i < cubos.Length; i++)
        //    {
        //        cubos[i].transform.position = new Vector3(0, 0, 0);
        //    }


        // Posicionar los cubos en "Escalerita" 

        int desplazo = 0;
        for (int i = 0; i < cubos.Length; i++)
        {
            cubos[i].transform.position = new Vector3(desplazo, desplazo, 0);
            desplazo = desplazo + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
