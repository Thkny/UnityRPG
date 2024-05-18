using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    //! MANA !//
    public float manaInicial = 100f;
    public float decrementoMana = 1f;
    public float manaAtual;
    public Slider sliderMana;


    //! DASH !//
    [SerializeField] float speed = 5f;
    [SerializeField] float dashSpeed = 40f;
    float speedAtual;


    //! PERSONAGEM !//
    private Rigidbody2D playerRb;


    void Start() {
        playerRb = GetComponent<Rigidbody2D>();
        manaAtual = manaInicial;

    }

    private void start(){
        speedAtual = speed;
    }

    void Update() {
        float eixoX = Input.GetAxisRaw("Horizontal") * speedAtual;
        float eixoY = Input.GetAxisRaw("Vertical") * speedAtual;
        playerRb.velocity = new Vector2(eixoX, eixoY);

        if(Input.GetKeyDown("space")){
            speedAtual = dashSpeed;
            Invoke("posDash", 0.1f);
         }
    }

    void atualizarSliderMana() {
        sliderMana.value = manaAtual / manaInicial;
    }

    void posDash(){
        speedAtual = speed;
    }

}

