using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_12 : MonoBehaviour
{
    public string esferaTag = "esfera_test"; // Etiqueta de la esfera
    public float speed = 9f;

    private GameObject esfera; // Declaración del objeto esfera

    // Start is called before the first frame update
    void Start()
    {
        // Busca el objeto con la etiqueta "esfera_test" al inicio
        esfera = GameObject.FindGameObjectWithTag(esferaTag);
    }

    // FixedUpdate se utiliza para física, Update es para lógica
    void FixedUpdate()
    {
        Rigidbody cilindro = GetComponent<Rigidbody>();
        Vector3 esferaPosition = esfera.transform.position;

        float HorizontalInput = Input.GetAxisRaw("HEsfera"); // Cambié los ejes a "Horizontal" y "Vertical"
        float VerticalInput = Input.GetAxisRaw("VEsfera");
        Vector3 mov = new Vector3(HorizontalInput, 0, VerticalInput); // Cambié la dirección del movimiento

        // Mueve el cilindro en la dirección del movimiento
        cilindro.MovePosition(transform.position + mov * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.M))
        {
            
            Vector3 directionToEsfera = esferaPosition - transform.position;
            directionToEsfera.Normalize();
            cilindro.MovePosition(transform.position + directionToEsfera * speed * Time.deltaTime);
        }
    }
}
