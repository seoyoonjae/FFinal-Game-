using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float maxSpeed;
    public int nextMove;
    Animator animator;
    SpriteRenderer spriteRenderer;


        


    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        Invoke("Think", 5);
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);
    }

    void Think()
    {
        nextMove = Random.Range(-1, 2);

        Invoke("Think", 5);

        animator.SetInteger("WalkSpeed", nextMove);

        // Flip Sprite
        if (nextMove != 0)
        spriteRenderer.flipX = nextMove == 1;
           
    }
    
}
