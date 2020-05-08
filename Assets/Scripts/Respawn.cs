using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Vector3[] spawnPointsArray;  //1D array of spawn points
    public GameObject thermoStat;
   
    public bool escapeOnset; //determines if feetPainting has been set as new material for floors
    public bool seizureOnset;
    public bool spiritGuideOnset;
    public bool seizureOnset2;
    //public bool fireTouch;

    public GameObject earth;
    public GameObject exitBlockers;
    //public GameObject firePit;

    public Material feetPainting;
    public Material limbsPainting;

    public Light environmentLight;

    public GameObject feet;




    private void Awake()
    {
        escapeOnset = false;        //upon start of play, trauma did not occur
        seizureOnset = false;   //seizure has not yet occured
        spiritGuideOnset = false;
        seizureOnset2 = false;
        //fireTouch = false;

        spawnPointsArray = new Vector3[5]; //defining size of spawnPointsArray

        //defining spawn points
        spawnPointsArray[0] = new Vector3(8.95f, 3.12f, 12.58f); //Living Room
        spawnPointsArray[1] = new Vector3(92.21f, 0f, -26.17f); //Drivewayy end
        spawnPointsArray[2] = new Vector3(4.11f, 0f, -50.42f);  //Shop
        spawnPointsArray[3] = new Vector3(4.5f, 10.4f, -10.9f); //Attic
        spawnPointsArray[4] = new Vector3(8.2f, 10.4f, 12.4f);  //Jessie's bedroom

        gameObject.transform.position = spawnPointsArray[Random.Range(0, 6)]; //spawn/start point is randomly in one of the 5 different position every time

    }
    void Update()
    {
        if (thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0 && seizureOnset == false)        //if player discovered the "thermostat"/HeartOnAstickPainting (managed in ThermoStatInfo Class)
        {
            seizureOnset = true;
        }

        checkConfig();  //check to see where state of trauma is and execute certain actions depending on this state before respawning


    }

    //checks for trauma events and if they have occured. depedning on if they have occured or not, will reconfigure certain settings
    public void checkConfig()
    {
        if (gameObject.transform.position.y <= -200)      //if player falls off the edge
        {
            gameObject.transform.position = spawnPointsArray[Random.Range(0, 6)];    //If user falls off edge, respawn in one of the 5 assigned places, randomly
        }

        if (seizureOnset2 == true)
        {
            seizureOnset = true;
            exitBlockers.SetActive(true);   
            environmentLight.color = new Color32(0, 0, 0, 0);

            earth.GetComponent<MeshCollider>().enabled = false;

            gameObject.GetComponent<FirstPersonAIO>().walkSpeed = 10.0f;
            gameObject.GetComponent<FirstPersonAIO>().sprintSpeed = 1.0f;
            gameObject.GetComponent<FirstPersonAIO>().verticalRotationRange = 120f;
            gameObject.GetComponent<FirstPersonAIO>().jumpPower = 8.0f;

            seizureOnset2 = false;

        }

        if(thermoStat.GetComponent<ThermoStatInfo>().thermoTemp >= 1)   //this occurs if they find the clock/skirt during the seizure
        {
            exitBlockers.SetActive(false);
        }

        if (thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 1 && spiritGuideOnset == false)
        {
            earth.GetComponent<MeshCollider>().enabled = true;

            if (spiritGuideOnset == false)
            {
                feet.SetActive(true);
                spiritGuideOnset = true;
                escapeOnset = true;

            }
        }

        if (escapeOnset == true)
        {
            thermoStat.GetComponent<ThermoStatInfo>().thermoTemp = 2;

            foreach (GameObject wall in GameObject.FindGameObjectsWithTag("limbs")) //MOVE LATER
            {
                wall.GetComponent<Renderer>().material = limbsPainting;
            }
            //girls on wall help you regain footing

        }
        
        if(thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 3)
        {
            gameObject.GetComponent<FirstPersonAIO>().walkSpeed = 4.0f;
            gameObject.GetComponent<FirstPersonAIO>().sprintSpeed = 9.0f;

            gameObject.GetComponent<FirstPersonAIO>().verticalRotationRange = 170f;
            gameObject.GetComponent<FirstPersonAIO>().jumpPower = 5.5f;

        }



    }
    }

