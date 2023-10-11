using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_7 : MonoBehaviour
{
    public string cuboTag = "red_cube"; // Etiqueta del cubo
    public string esferaTag = "esfera_test"; // Etiqueta de la esfera
    public float speed = 5f; // Velocidad de movimiento
    private GameObject cubo;
    private GameObject esfera;

    // Start is called before the first frame update
    void Start()
    {
        // Buscar el cubo y la esfera en la escena
        cubo = GameObject.FindGameObjectWithTag(cuboTag);
        esfera = GameObject.FindGameObjectWithTag(esferaTag);
    }

    // Update is called once per frame
    void Update()
    {
        // Obtén las posiciones del cubo y la esfera
        Vector3 cuboPosition = cubo.transform.position;
        Vector3 esferaPosition = esfera.transform.position;

        // Calcula la dirección hacia la esfera sin modificar la altura
        Vector3 direction = esferaPosition - cuboPosition;

        // Gira el cubo para que mire hacia la esfera
        cubo.transform.LookAt(esferaPosition);

        cubo.transform.Translate(direction * speed * Time.deltaTime);

        // Movimiento de la esfera con las teclas
        float esferaHorizontalInput = Input.GetAxisRaw("HEsfera");
        float esferaVerticalInput = Input.GetAxisRaw("VEsfera");
        Vector3 esferaMovement = new Vector3(esferaHorizontalInput, 0, esferaVerticalInput) * speed * Time.deltaTime;
        esfera.transform.Translate(esferaMovement);
    }
}
