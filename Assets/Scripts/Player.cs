using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int playerPosition;
    public GameObject position1;
    public GameObject position2;
    public GameObject position3;

    //public GameObject gameOverScreen;



    // Start is called before the first frame update
    void Start()
    {
     playerPosition = 1;
     
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPosition == 1)
        transform.position = position1.transform.position;

        if(playerPosition == 2)
        transform.position = position2.transform.position;

        if(playerPosition == 3)
        transform.position = position3.transform.position;

        if(Input.GetKeyDown("left")) 
         if(playerPosition == 1) 
            playerPosition = 3;
            else
            playerPosition -=1;
        
        if(Input.GetKeyDown("right")) 
         if(playerPosition == 3) 
            playerPosition = 1;
            else
            playerPosition +=1;


   
    }



}
