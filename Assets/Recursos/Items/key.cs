using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(0, 0);
        //hacer flotar la llave en el aire de arriba a abajo
        movement.y = Mathf.Sin(Time.time * 3) * 0.25f;
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
