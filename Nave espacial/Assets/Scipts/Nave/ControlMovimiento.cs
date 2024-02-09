using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovimiento : MonoBehaviour
{
    public float speed = 5f;  // Velocidad de movimiento
    public float rotationSpeed = 100f;  // Velocidad de rotación
    public float jumpForce = 10f;  // Fuerza de salto

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Rotación con las teclas izquierda y derecha
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0f)  // Solo rota si se presiona una tecla de rotación
        {
            transform.Rotate(Vector3.up * -horizontalInput * rotationSpeed * Time.deltaTime);
        }

        // Movimiento hacia adelante con la tecla de espacio
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * jumpForce, ForceMode.Impulse);
        }


    }

    private void LateUpdate()
    {
        // controlar para que la nave no se mueva en el eje z
        Vector3 pos = gameObject.transform.position;
        pos.z = 0;
        gameObject.transform.position = pos;
    }



}
