using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //public float moveSpeed = 5f;
    public float force;
    
    public float rotationSpeed = 5f;
    float speedX, speedY;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Player");
        //speedX = Input.GetAxis("Horizontal") * moveSpeed;
        //speedY = Input.GetAxis("Vertical") * moveSpeed;
        //rb.velocity = new Vector2(speedX, speedY);

       


            if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            
            foreach (GameObject obj in objectsWithTag)
            {

                float rotationAngle = rotationSpeed * Time.deltaTime;
                obj.transform.Rotate(0, 0, rotationAngle * 2);
            }
        }
        else if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            foreach (GameObject obj in objectsWithTag)
            {

                float rotationAngle = rotationSpeed * Time.deltaTime;
                obj.transform.Rotate(0, 0, -rotationAngle * 2);
            }
        }


       

    }


}
