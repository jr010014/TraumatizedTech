using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject skyBoxShell;

    void Start()
    {
        //skyBoxShell.GetComponent<MeshRenderer>().enabled = false;
        skyBoxShell.SetActive(false);
    }

    void Update()
    {
        /*if (GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            skyBoxShell.SetActive(true);

        }
        */
    }
}
