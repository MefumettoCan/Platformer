using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool zipla = true;
    bool sagabak = true;
    public float jumpForce;
    float horizontal;
    Vector3 scale;
    Animator playerAnimator;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&zipla ==true)
        {
            rb.AddForce(new Vector2(200,jumpForce));
            zipla = false;
        }
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(horizontal * Time.deltaTime * speed,rb.velocity.y,200);
        if (horizontal>0 && sagabak == false)
        {
            cevir();
        }
        if (horizontal<0 && sagabak == true)
        {
            cevir();
        }
        playerAnimator.SetFloat("Speed",Mathf.Abs(moveInput))
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Platform")
        {
            zipla = true;
        }
    }

    void cevir()
    {
        sagabak = !sagabak;
        scale = gameObject.transform.localScale;
        scale.x = scale.x*-1;
        gameObject.transform.localScale = scale;
    }
}

