using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_8 : MonoBehaviour
{
    public string cuboTag = "red_cube"; // Etiqueta del cubo
    public float speed = 5f; // Velocidad de movimiento
    private GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        // Buscar el cubo en la escena
        cubo = GameObject.FindGameObjectWithTag(cuboTag);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("HCubo");
        cubo.transform.Rotate(0, horizontalInput, 0);

        // Obtener la dirección hacia adelante del cubo en su espacio local
        Vector3 forwardDirection = cubo.transform.forward;

        // Dibuja una línea de depuración para visualizar la dirección hacia adelante
        Debug.DrawRay(cubo.transform.position, forwardDirection, Color.green);

        // Mover el cubo hacia adelante en función de la dirección hacia adelante
        cubo.transform.Translate(forwardDirection * speed * Time.deltaTime, Space.World);
    }
}
