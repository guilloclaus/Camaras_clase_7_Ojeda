using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Velocidad = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Velocidad * Time.deltaTime * Vector3.left);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Velocidad * Time.deltaTime * Vector3.right);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Velocidad * Time.deltaTime * Vector3.forward);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Velocidad * Time.deltaTime * Vector3.back);

    }
}
