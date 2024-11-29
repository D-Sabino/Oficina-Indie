using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3 : MonoBehaviour
{
    public string letra;
    void Start()
    {
        if (letra.ToLower() == "a" || letra.ToLower() == "e" || letra.ToLower() == "i" || letra.ToLower() == "o" || letra.ToLower() == "u")
        {
            Debug.Log(letra + " é uma vogal.");
        }
        else {
            Debug.Log(letra + " é uma consoante.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
