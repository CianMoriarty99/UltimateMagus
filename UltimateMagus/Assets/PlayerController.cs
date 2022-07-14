using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float x,y, speed;
    public Vector2 dir;
    bool walkable;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        dir = new Vector2(x,y);
    }

    //Put physics in fixed update from frame-independent movement
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + dir.normalized * speed * Time.fixedDeltaTime);
    }



}