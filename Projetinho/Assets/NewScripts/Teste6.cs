using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste6 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int number = 5;
        switch (number) {

            case 1:
                Debug.Log("N�mero 1");
                break;

            case 2:
                Debug.Log("N�mero 2");
                break;

            case 3:
                Debug.Log("N�mero 3");
                break;

            case 4:
                Debug.Log("N�mero 4");
                break;

            default:
                Debug.Log("Nenhuma das op��es");
                break;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
