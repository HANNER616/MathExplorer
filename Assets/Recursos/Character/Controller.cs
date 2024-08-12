using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //public float moveSpeed = 5f;
    public float force;
    
    public float rotationSpeed = 5f;
    float speedX, speedY;
    Rigidbody2D rb;
    public bool hasAllKeys = false;

    private int auxKeys = 0;

    public GameLogic logica;
    private GameObject[] objectsWithTag;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        objectsWithTag = GameObject.FindGameObjectsWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        


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
    
    //Colision con la llave
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Key")){
            int numKeys = logica.GetNumKeys;
           
            HandleCollision(collision.gameObject, numKeys);
        }
        
    }

    void HandleCollision(GameObject obj, int numeroLlaves)
    {
        
        auxKeys++;
        if (auxKeys == numeroLlaves)
        {
            hasAllKeys = true;
            Debug.Log("Llave recogida");
            auxKeys = 0;
            Destroy(obj);
        }
    }

    public bool HasAllKeys
    {
        get { return hasAllKeys; }
        set { hasAllKeys = value; }
    }

    

    public int GetAuxKeys
    {
        get { return auxKeys; }
    }


}
