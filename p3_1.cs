using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3_1 : MonoBehaviour
{
    float velocidad = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxis("HCubo");
        float inputVertical = Input.GetAxis("VCubo");

        if (Input.GetKeyDown(KeyCode.UpArrow))
        { Debug.Log("Flecha arriba - Resultado Eje Vertical: " + (velocidad * inputVertical) +
              " - Resultado Eje Horizontal: " + (velocidad * inputHorizontal));
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        { Debug.Log("Flecha abajo - Resultado Eje Vertical: " + (velocidad * inputVertical) +
              " - Resultado Eje Horizontal: " + (velocidad * inputHorizontal));
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { Debug.Log("Flecha izquierda - Resultado Eje Vertical: " + (velocidad * inputVertical) +
              " - Resultado Eje Horizontal: " + (velocidad * inputHorizontal));
        }

       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        { Debug.Log("Flecha derecha - Resultado Eje Vertical: " + (velocidad * inputVertical) +
              " - Resultado Eje Horizontal: " + (velocidad * inputHorizontal));
        }

    
    }

}
