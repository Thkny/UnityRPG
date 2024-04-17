using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste5 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int number = -5;
        string message = number > 0 ? "numero possitivo" : "numero negativo";
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update() {

    }
}
