using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandClock : MonoBehaviour
{
    //This class controls motion of hands on clock


    public GameObject bigHand;
    public GameObject littleHand;
    public GameObject pendulum;
    bool pendSwing;
    int pendulumSpeed = 60;

   
    private void Update()
    {
        littleHand.transform.Rotate(new Vector3(360f, 0f, 0f) * Time.deltaTime);
        bigHand.transform.Rotate(new Vector3(30f, 0f, 0f) * Time.deltaTime);
        pendulumSwing();
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

}
