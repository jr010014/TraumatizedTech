using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    public Material growthPainting;
    public GameObject backSkyWall;
    public GameObject bridge;
    public GameObject garden;

    public GameObject escapeOnset;

    public void OnCollisionEnter(Collision collider)
    {
        //spawn Garden

        if (collider.gameObject.tag == "Player" && escapeOnset.GetComponent<Respawn>().escapeOnset== true)
        {
            backSkyWall.GetComponent<Renderer>().material = growthPainting;
            bridge.SetActive(true);
            garden.SetActive(true);
        }
    }
}
