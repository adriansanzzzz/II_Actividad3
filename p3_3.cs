using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_3 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, 0, 0); // Dirección del movimiento en el inspector
    public float speed = 2f; // Velocidad de movimiento en el inspector


     void Start()
    {
        // Asegura que el cubo comience en la posición y=0
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {

        // Calcula el desplazamiento en base a la dirección
        Vector3 cubeMovement = moveDirection * speed * Time.deltaTime;
        cubeMovement.Normalize();
        transform.Translate(cubeMovement); // Mueve el cubo
        //transform.Translate(cubeMovement,Space.World); 

        



    }
}
