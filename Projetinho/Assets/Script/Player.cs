using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    // dash //

    private bool canDash = true;
    private bool isDashing; // dash ativo
    private float dashingPower = 1000f; // força do dash
    private float dashingTime = 0.2f; //tempo do dash né
    private float dashingCoolDown = 0.5f;
    [SerializeField] TrailRenderer tr;

    // mana ou coisa do tipo //

    public float manaInicial = 100f;
    public float decrementoMana = 1f;
    public float manaAtual;
    public Slider sliderMana;


    // personagemm //
    private Rigidbody2D playerRb;
    public float velocidade = 5f;


    void Start() {
        playerRb = GetComponent<Rigidbody2D>();
        manaAtual = manaInicial;

    }

    void Update() {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
        playerRb.velocity = new Vector2(eixoX, eixoY);

        if (Input.GetKeyDown("space") && canDash == true) {
            StartCoroutine(Dash());
        }

        if (isDashing) {
            return;
        }

    }

    void atualizarSliderMana() {
        sliderMana.value = manaAtual / manaInicial;
    }

    IEnumerator Dash() {
        canDash = false;
        isDashing = true;
        float originalGravity = playerRb.gravityScale;
        playerRb.gravityScale = 0f;
        playerRb.velocity = new Vector2(transform.localScale.x * dashingPower, 0);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        playerRb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCoolDown);
        canDash = true;
    }
}

