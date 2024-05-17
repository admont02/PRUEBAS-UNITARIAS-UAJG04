using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class IndicadorRadial : MonoBehaviour
{
    public GameObject player;
    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            Debug.LogError("El jugador no est� asignado en IndicadorRadial.");
        }

        if (sound == null)
        {
            Debug.LogError("El sonido no est� asignado en IndicadorRadial.");
        }

        //float inclination = (pSound.z - pPlayer.z) / (pSound.x - pPlayer.x);
        //print("La pendiente es : " + inclination);

        //print("El coseno es de : " + cosinus);

        //print("La posici�n del indicador ser�a : X = " + 100 * sinus + " Y = " + 100 * cosinus);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null | sound == null) return;

        Vector3 pPlayer = player.transform.forward;
        Vector3 pSound = sound.transform.position;

        double angle = CalculateAngle(pPlayer, pSound);
        Debug.Log($"El �ngulo es de : {angle}");

        //print("Una posici�n ser�a : " + (angle * Math.PI / 180));
        double sinus = Mathf.Sin((float)angle);
        double cosinus = Mathf.Cos((float)angle);

        //print("Un punto ser�a: X -> " + (cosinus) + " Y -> " + (sinus));
    }

    /// <summary>
    /// Calcula el �ngulo entre el jugador y la fuente del sonido.
    /// </summary>
    /// <param name="playerPosition">Posici�n del jugador.</param>
    /// <param name="soundPosition">Posici�n de la fuente del sonido.</param>
    /// <returns>El �ngulo en grados</returns>
    double CalculateAngle(Vector3 playerPosition, Vector3 soundPosition)
    {
        Vector3 directionToSound = soundPosition - playerPosition;
        double angle = Mathf.Atan2(directionToSound.z, directionToSound.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;
        return angle;
    }
}
