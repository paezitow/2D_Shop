using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private LojaController shop;
    void FixedUpdate()
    {
        Vector2 direcaoMovimento = new Vector2(MoveLeftRigh(), MoveUpDown());

        direcaoMovimento.Normalize();

        movePlayer(direcaoMovimento);
    }

    void movePlayer(Vector2 direction)
    {
        Vector2 posicaoAlvo = (Vector2)transform.position + direction * speed * Time.deltaTime;

        transform.position = posicaoAlvo;
    }

    public float MoveUpDown()
    {
        float vertical = Input.GetAxis("Vertical");
        return vertical;
    }

    public float MoveLeftRigh()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal == 1)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (horizontal == -1) 
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().flipX = false;
        }
        return horizontal;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Barrier")
        {
            print("tocou na barreira");
        }
        shop.Show();
        print("Entrou na loja");
    }
}
