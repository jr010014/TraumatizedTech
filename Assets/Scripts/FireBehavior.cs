using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavior : MonoBehaviour
{
    public bool iAmTheFire; //did the light transfer to the avatar player?

    public void Start()
    {
        iAmTheFire = false;
    }

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            transferFire(collider);
        }
    }

    public void transferFire(Collision collider)
    {
        Debug.Log("line2");

        collider.gameObject.GetComponent<Light>().enabled = true;
        iAmTheFire = true;
    }
}
