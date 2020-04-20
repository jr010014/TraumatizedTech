using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject skyBoxShell;
    public GameObject thermoStat;
    public GameObject houseStruct;

    void Start()
    {
        //skyBoxShell.GetComponent<MeshRenderer>().enabled = false;
        skyBoxShell.SetActive(false);
    }

    void Update()
    {
        if (thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            skyBoxShell.SetActive(true);

            foreach(Transform houseStructChild in houseStruct.transform)
            {
                houseStructChild.GetComponent<Renderer>().material = null;
            }

        }
        
    }
}
