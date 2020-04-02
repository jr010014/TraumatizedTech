using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPPOV_Move : MonoBehaviour
{

    public float speed = 10.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        float translate = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translate *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translate);

        if(Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
