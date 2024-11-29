using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4 : MonoBehaviour
{

    public int lado1, lado2, lado3;

    void Start()
    {
        if (lado1 == lado2 && lado1 == lado3)
        {
            Debug.Log("Triangulo é equilátero.");
        }
        else if (lado1 == lado2 ||  lado1 == lado3 || lado2 == lado3)
        {
            Debug.Log("Triangulo é isóceles.");
        }
        else{
            Debug.Log("Triangulo é escaleno.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
