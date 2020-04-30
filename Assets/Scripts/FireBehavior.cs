using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehavior : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

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
