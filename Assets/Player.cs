using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;
    public float jumpSpeed;
    private bool isJump = false;
    Rigidbody2D rigid;
    SpriteRenderer render;

    // Start is called before the first frame update
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * horizontal, ForceMode2D.Impulse);
        if(rigid.velocity.x > maxSpeed)
        {
            render.flipX = false;
           
        }
        else if (rigid.velocity.x < maxSpeed * (-1))
        {
            render.flipX = true;
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
        if(Input.GetButtonDown("Jump") && isJump == false)
        {
            rigid.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            isJump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Land")
        {
            isJump = false;
        }
    }
    
    
        
    

}

