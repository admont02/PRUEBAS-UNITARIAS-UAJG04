using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 5.0f;

    float rotation = 0.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Actualizamos la posición del jugador en cada frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 localMovement = transform.TransformDirection(movement) * speed;

        rb.velocity = new Vector3(localMovement.x, rb.velocity.y, localMovement.z);


        if (Input.GetKey(KeyCode.Q)) rotation = -rotationSpeed;
        else if (Input.GetKey(KeyCode.E)) rotation = rotationSpeed;
        else rotation = 0.0f;

        transform.Rotate(Vector3.up, rotation * rotationSpeed * Time.deltaTime);
    }
}
