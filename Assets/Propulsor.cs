using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propulsor : MonoBehaviour
{
    public float moveAmount = 1f; // Cantidad de movimiento por actualización
    private Vector3 originalPosition;
    private bool isActive = false;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }

        if (isActive)
        {
            aplicarPropulsion();
        }
        else
        {
            transform.localPosition = originalPosition;
        }
    }

    void aplicarPropulsion()
    {
        transform.localPosition = originalPosition + Vector3.up * moveAmount;
    }
}
