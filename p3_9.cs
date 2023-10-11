using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colisionó tiene una etiqueta y muestra un mensaje en la consola
        if (collision.collider.CompareTag("red_cube"))
        {
            Debug.Log("El cubo ha colisionado con el cilindro.");
        }
        else if (collision.collider.CompareTag("esfera_test"))
        {
            Debug.Log("La esfera ha colisionado con el cilindro.");
        }
    }

}
