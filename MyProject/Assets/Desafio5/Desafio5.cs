using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio5 : MonoBehaviour
{
    public string jogador1, jogador2;
    public int mao_jogador_1, mao_jogador_2;
    private int soma, mod;
    public bool jogador1_parimpar, jogador2_parimpar; // False - Par, True - Impar

    void Start()
    {

        if(jogador1_parimpar == jogador2_parimpar)
        {
            string maojogador;

            if (jogador1_parimpar == false) //Escolheu par
            {
                maojogador = "Par";
                jogador2_parimpar = true; //Jogador 2 recebe impar
            }
            else //Escolheu impar
            {
                maojogador = "Impar";
                jogador2_parimpar= false; //Jogador 2 recebe par
            }
                

            Debug.Log("Ambos escolheram " + maojogador + ". O jogador 2, sera alterado.");

        }

        soma = mao_jogador_1 + mao_jogador_2;
        mod = soma % 2;

        if(mod == 0)
        {
            if (jogador1_parimpar == false)
            {
                Debug.Log(soma + " é um número par, pontando " + jogador1 + " venceu!");
            }
            else
            {
                Debug.Log(soma + " é um número par, pontando " + jogador2 + " venceu!");
            }
        }
        else
        {
            if (jogador1_parimpar == true)
            {
                Debug.Log(soma + " é um número impar, pontando " + jogador1 + " venceu!");
            }
            else
            {
                Debug.Log(soma + " é um número impar, pontando " + jogador2 + " venceu!");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
