using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste4 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int number = 13;
        if (number > 0) {
            Debug.Log(" O numero é maior que zero");

        } else if (number == 0 ) {
            Debug.Log(" O numero é igual a zero");

        } else {
            Debug.Log(" O numero não é maior que zero");
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
