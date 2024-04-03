using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testes : MonoBehaviour {
    
    void Start() {

        // Variaveis e tipos de dados

        int var = 10;
        float peso = 61.08f;
        double medida = 9.99999999;
        bool ativado = false;
        string texto = "fala boy";


        Debug.Log("inteiro: " + var);
        Debug.Log("Peso: " + peso);
        Debug.Log("Medida: " + medida);
        Debug.Log("Ativado: " + ativado);
        Debug.Log("Texto: " + texto);


        // Operadores aritmeticos

        int soma = 2 + 2;
        int sub = 9 - 5;
        int mult = 2 * 3;
        int div = 9 / 3;


        Debug.Log("Soma: " + soma);
        Debug.Log("Subtração: " + sub);
        Debug.Log("Multiplicação: " + mult);
        Debug.Log("Divisão: " + div);

    }




    void Update() {

    }
}
