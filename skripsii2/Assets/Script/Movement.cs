using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private SpriteRenderer spr;
    public float speed=10f;
    float x;
    float y;
    bool facingRight = true;
    public Rigidbody2D rb;
    public GameObject Book;
    public Joystick joystick;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        OpenBook();
    }

    private void FixedUpdate()
    {
        x = joystick.Horizontal;
        y = joystick.Vertical;
        if (x != 0)
        {
            rb.velocity = new Vector2(x * speed, y * speed);
            animator.SetBool("isMoving", true);
        }
        else
        {
            rb.velocity = Vector2.zero;
            animator.SetBool("isMoving", false);
        }
        if (x < 0 && facingRight)
        {
            Flip();
        }
        else if (x > 0 && !facingRight)
        {
            Flip();
        }
    }
    private void Mover()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        Vector3 moves = new Vector3(x , y,0);
        rb.velocity = moves * speed * Time.deltaTime;
    }
    void Flip()
    {
        Vector2 CurrentScale = gameObject.transform.localScale;
        CurrentScale.x *= -1;
        gameObject.transform.localScale = CurrentScale;
        facingRight = !facingRight;
    } 
    void OpenBook()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Book.SetActive(true);
        }
    }
}
