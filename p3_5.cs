using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_5 : MonoBehaviour
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
         // Movimiento del cubo con las teclas de flecha
        float horizontalInput = Input.GetAxis("HCubo");
        float verticalInput = Input.GetAxis("VCubo");
        Vector3 cuboMovement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;
        cubo.transform.Translate(cuboMovement);

        // Movimiento de la esfera con las teclas W, S, A, D
        float esferaHorizontalInput = Input.GetAxis("HEsfera");
        float esferaVerticalInput = Input.GetAxis("VEsfera");
        Vector3 esferaMovement = new Vector3(esferaHorizontalInput, esferaVerticalInput, 0) * speed * Time.deltaTime;
        esfera.transform.Translate(esferaMovement);
        
    }
}
