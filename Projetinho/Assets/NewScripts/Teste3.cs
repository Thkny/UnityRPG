using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste3 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int a = 10;
        int b = 20;
        int c = 30;

        bool resul1 = (a < b) & (b < c);
        Debug.Log("(a < b) & (b < c)? " + resul1);

        bool resul2 = (a > b) || (b < c);
        Debug.Log("(a > b) || (b < c)? " + resul2);

        bool resul3 = (a < b) & (b < c) || (a == 10);
        Debug.Log("(a < b) & (b < c) || (a == 10)? " + resul3);

        bool resul4 = (a > b);
        Debug.Log("(a > b)? " + resul4);
    }

    // Update is called once per frame
    void Update() {

    }
}
