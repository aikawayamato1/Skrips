using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed=10f;
    float x;
    float y;
    bool facingRight=true;
    public Rigidbody2D rb;
    public GameObject Book;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Facing();
        OpenBook();
    }
    private void Mover()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        Vector3 moves = new Vector3(x , y,0);
        rb.velocity = moves * speed * Time.deltaTime;

    }
    void Facing()
    {
        if(x<0 && facingRight)
        {
            Flip();
        }
        if (x > 0 && !facingRight)
        {
            Flip();
        }
    }
    void Flip()
    {
        Vector2 CurrentScale = transform.localScale;
        CurrentScale.x *= -1;
        transform.localScale = CurrentScale;
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
