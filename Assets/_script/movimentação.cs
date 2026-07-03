using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Velocidade do personagem
    public float speed = 5f;

    // Referência ao Rigidbody2D
    private Rigidbody2D rb;

    // Vetor que armazenará a direção do movimento
    private Vector2 movement;

    // Executado quando o jogo inicia
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Executado a cada quadro
    void Update()
    {
        // Lê as teclas WASD e as setas do teclado
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Executado em intervalos fixos (ideal para física)
    void FixedUpdate()
    {
        // Move o personagem
        rb.velocity = movement.normalized * speed;
    }
}