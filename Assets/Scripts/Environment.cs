using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject skyBoxShell;
    public GameObject thermoStat;
    public GameObject houseStruct;

    public bool materialsSet;

    void Start()
    {
        //skyBoxShell.GetComponent<MeshRenderer>().enabled = false;
        materialsSet = false;
        skyBoxShell.SetActive(false);
    }

    void Update()
    {
        if (materialsSet == false && thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            skyBoxShell.SetActive(true);

            foreach(Transform houseStructChild in houseStruct.transform)
            {
                houseStructChild.GetComponent<Renderer>().material = null;
            }

            materialsSet = true;

        }
        
    }
}
