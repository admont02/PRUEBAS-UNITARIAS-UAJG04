using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfRun : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit
        this.gameObject.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Debug.Log("trigger");
            this.gameObject.transform.Rotate(new Vector3(0, 1, 0), -90);
        }
    }
}
