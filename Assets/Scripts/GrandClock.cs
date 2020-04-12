using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandClock : MonoBehaviour
{
    public GameObject bigHand;
    public GameObject littleHand;
    public GameObject pendulum;


    private void Update()
    {
        littleHand.transform.Rotate(new Vector3(360f, 0f, 0f) * Time.deltaTime);
        bigHand.transform.Rotate(new Vector3(30f, 0f, 0f) * Time.deltaTime);
        if (Mathf.Abs(pendulum.transform.eulerAngles.x) > 4)
        {
            pendulumSwing();
        }

    }

    public void pendulumSwing()
    {
        if (pendulum.transform.eulerAngles.x >= 4)
        {
            pendulum.transform.Rotate(new Vector3(-6f, 0f, 0f) * Time.deltaTime);

        }
        else if (pendulum.transform.eulerAngles.x < -4)
        {
            pendulum.transform.Rotate(new Vector3(6f, 0f, 0f) * Time.deltaTime);
        }
    }

        /*
       public GameObject bigHand;
       public GameObject littleHand;
       public GameObject Pendulum;
       string oldSeconds;

       void Update()
       {
           string seconds = System.DateTime.UtcNow.ToString("ss");

          if(seconds != oldSeconds)
          {
            UpdateTimer();
          }
          oldSeconds = seconds;
       }

       void UpdateTimer()
       {
           int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
           int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
           int hoursInt = int.Parse(System.DateTime.UtcNow.ToString("hh"));


           print(secondsInt);
           print(minutesInt);
           print(hoursInt);

           iTween.RotateTo(littleHand, iTween.Hash("x", secondsInt * 6 * -1, "time", 1, "easetype", "easeOutQuint"));
           iTween.RotateTo(bigHand, iTween.Hash("x", minutesInt * 6 * -1, "time", 1, "easetype", "easeOutQuint"));

       }
       */
    }
