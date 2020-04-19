using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   
    public Vector3[] spawnPointsArray;  //1D array of spawn points

    private void Awake()
    {
        spawnPointsArray = new Vector3[5]; //defining size of spawnPointsArray

        spawnPointsArray[0] = new Vector3(8.95f, 3.12f, 12.58f); //Living Room
        spawnPointsArray[1] = new Vector3(92.21f, 0f, -26.17f); //Drivewayy end
        spawnPointsArray[2] = new Vector3(4.11f, 0f, -50.42f);  //Shop
        spawnPointsArray[3] = new Vector3(4.5f, 10.4f, -10.9f); //Attic
        spawnPointsArray[4] = new Vector3(8.2f, 10.4f, 12.4f);  //Jessie's bedroom

        gameObject.transform.position = spawnPointsArray[Random.Range(0, 6)]; //spawn/start point is randomly in one of the 5 different position every time


    }
    void Update()
    {
       if(gameObject.transform.position.y <= -200)
       {
           gameObject.transform.position = spawnPointsArray[Random.Range(0, 6)];    //If user falls off edge, respawn in of the 5 assigned placed, ramdomly
           Debug.Log(Random.Range(0, 6));
       }
       
    }
    
}
