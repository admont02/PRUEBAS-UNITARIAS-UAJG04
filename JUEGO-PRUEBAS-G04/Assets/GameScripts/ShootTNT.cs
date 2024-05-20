using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTNT : MonoBehaviour
{
    [SerializeField]
    private GameObject tnt;
    [SerializeField]
    private float generateTime = 1.0f;
    [SerializeField]
    private float distance = 10.0f;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;
        if (time <= 0f)
        {
            transform.Rotate(0, Random.Range(20.0f,90.0f), 0);
            // Generar el objeto
            Vector3 tntPos=transform.position + transform.forward*distance;
            GameObject nuevoObjeto = Instantiate(tnt, tntPos, Quaternion.identity);

            // Reiniciar el tiempo restante
            time = generateTime;
        }
    }
    
}
