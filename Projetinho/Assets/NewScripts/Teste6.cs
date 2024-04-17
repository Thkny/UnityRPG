using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste6 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int number = 5;
        switch (number) {

            case 1:
                Debug.Log("Número 1");
                break;

            case 2:
                Debug.Log("Número 2");
                break;

            case 3:
                Debug.Log("Número 3");
                break;

            case 4:
                Debug.Log("Número 4");
                break;

            default:
                Debug.Log("Nenhuma das opções");
                break;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
