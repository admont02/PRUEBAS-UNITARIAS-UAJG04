using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    /// <summary>
    /// Distancia m�xima que el objeto se mover� hacia arriba y hacia abajo
    /// </summary>
    public float amplitude = 1f;

    /// <summary>
    /// Velocidad a la que el objeto se mover� hacia arriba y hacia abajo
    /// </summary>
    public float speed = 1f;

    /// <summary>
    /// Posici�n inicial del objeto
    /// </summary>
    private Vector3 startPosition;

    void Start()
    {
        // Guardar la posici�n inicial del objeto
        startPosition = transform.position;
    }

    void Update()
    {
        // Calcular la nueva posici�n del objeto
        float newPosX = startPosition.x + amplitude * Mathf.Sin(Time.time * speed);
        float newPosZ = startPosition.z + amplitude * Mathf.Sin(Time.time * speed);

        // Actualizar la posici�n del objeto
        //transform.position = new Vector3(newPosX, startPosition.y, startPosition.z);
        transform.position = new Vector3(startPosition.x, startPosition.y, newPosZ);
    }
}
