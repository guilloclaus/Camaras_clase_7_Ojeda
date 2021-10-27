using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject[] LstCamara;
    int posicion = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < LstCamara.Length; i++)
            {
                Debug.Log($"Camara seleccionada: {posicion}");
                LstCamara[i].SetActive(false);

                if (i == posicion)
                    LstCamara[posicion].SetActive(true);

                Debug.Log($"Camara: {i}, estado: {LstCamara[i].activeSelf.ToString()}");

            }

            if (posicion < LstCamara.Length - 1)
                posicion++;
            else
                posicion = 0;
        }

    }
}
