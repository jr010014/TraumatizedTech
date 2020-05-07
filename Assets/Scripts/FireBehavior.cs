using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavior : MonoBehaviour
{

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("line1");
            transferFire(collider);
        }
    }

    public void transferFire(Collision collider)
    {
        Debug.Log("line2");

        collider.gameObject.GetComponent<Light>().enabled = true;
    }
}
