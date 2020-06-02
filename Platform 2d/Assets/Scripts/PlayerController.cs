using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float heroSpeed;
    public float jumpForce;
    public Transform groundTester;
    float horizontalMove;
    Animator anim;
    Rigidbody2D rgBody;
    //Czy postac jest zwrocona w prawo 
    bool dirToRight = true;
    //Czy bohater dotyka ziemi
    bool onTheGround;
    float radius = 0.1f;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
        rgBody = GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        //Czy bohater dotyka ziemi 
        onTheGround = Physics2D.OverlapCircle(groundTester.position, radius);

        horizontalMove = Input.GetAxis("Horizontal");
        rgBody.velocity = new Vector2(horizontalMove * heroSpeed, rgBody.velocity.y); 

        if(Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            rgBody.AddForce(new Vector2(0f, jumpForce));
            anim.SetTrigger("jump");
        }

        anim.SetFloat ("speed", Mathf.Abs( horizontalMove));

        if (horizontalMove < 0 && dirToRight) 
        {
            Flip();
        }
        if (horizontalMove > 0 && !dirToRight)
        {
            Flip();
        }
    }
    //Zmiana obrotu wokol scali X na - X
    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }
}
