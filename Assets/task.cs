using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 movement = new Vector2(0, 0);
        movement.y = Mathf.Sin(Time.time * 3) * 0.25f;
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
