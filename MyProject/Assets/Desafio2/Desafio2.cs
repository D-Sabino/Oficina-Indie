using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    public int numero_1 = 0;
    public int numero_2 = 0;
    public int numero_3 = 0;
    int numero_maior = 0;


    void Start()
    {

        numero_maior = numero_1;

        if (numero_2 > numero_maior)
        {
            numero_maior = numero_2;
        }

        if (numero_3 > numero_maior)
        {
            numero_maior = numero_3;
        }

        Debug.Log("O maior número é: " +  numero_maior);


     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
