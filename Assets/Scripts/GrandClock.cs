using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandClock : MonoBehaviour
{
    //This class controls motion of hands on clock
    //As well as changes in when "trauma" occurs

    public GameObject bigHand;
    public GameObject littleHand;
    public GameObject pendulum;
    bool pendSwing;
    int pendulumSpeed;
    float littleHandRotSpeed;
    float bigHandRotSpeed;

    public GameObject thermoStat;
    public Material skirtPainting;
    public Material whiteWood;
    public bool changesMade;
    //public GameObject player;

    AudioSource clockChime;

    public void Start()
    {
        pendulumSpeed = 60;
        littleHandRotSpeed = 360f;
        bigHandRotSpeed = 30f;
        changesMade = false;

        clockChime = GetComponent<AudioSource>();

    }


    private void Update()
    {
        littleHand.transform.Rotate(new Vector3(littleHandRotSpeed, 0f, 0f) * Time.deltaTime);
        bigHand.transform.Rotate(new Vector3(bigHandRotSpeed, 0f, 0f) * Time.deltaTime);
        pendulumSwing();


        if (changesMade == false && thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            foreach (GameObject element in GameObject.FindGameObjectsWithTag("time"))
            {
                element.GetComponent<Renderer>().material = skirtPainting;
            }
            GameObject.FindGameObjectWithTag("grandClock").GetComponent<Renderer>().material = whiteWood;

            pendulumSpeed = 6;
            littleHandRotSpeed = 36f;
            bigHandRotSpeed = 3f;

            //clockPlayerChanges();

            changesMade = true;
        }

        if(thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            clockChime.Play();
        }

    }

    public void pendulumSwing()
    {
        if (pendulum.transform.eulerAngles.x < 180 && pendulum.transform.eulerAngles.x  >= 4 && pendSwing != true)
        {
            pendSwing = true;
        }
        else if (pendulum.transform.eulerAngles.x > 180 && pendulum.transform.eulerAngles.x - 360 <= -4 && pendSwing != false)
        {
            pendSwing = false;
        }

        if(pendSwing == true)
        {
            pendulum.transform.Rotate(new Vector3(-pendulumSpeed, 0f, 0f) * Time.deltaTime);
        }
        else if(pendSwing == false)
        {
            pendulum.transform.Rotate(new Vector3(pendulumSpeed, 0f, 0f) * Time.deltaTime);
        }
    }

    /*public void clockPlayerChanges()
    {
        player.GetComponent<FirstPersonAIO>().walkSpeed = 10.0f;
        player.GetComponent<FirstPersonAIO>().sprintSpeed = 1.0f;
        player.GetComponent<FirstPersonAIO>().verticalRotationRange = 120f;

    }
    */

}
