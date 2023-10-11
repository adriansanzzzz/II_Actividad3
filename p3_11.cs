using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("red_cube"))
        {
            Debug.Log("El cubo ha colisionado con el cilindro (trigger).");
        }
        else if (other.CompareTag("esfera_test"))
        {
            Debug.Log("La esfera ha colisionado con el cilindro (trigger)");
        }
}

}
