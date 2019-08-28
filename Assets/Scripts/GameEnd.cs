using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    { 
        //Debug.Log(hitInfo.gameObject.layer);
        if (hitInfo.gameObject.layer == 8) 
        {
            Destroy(hitInfo.gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    
}
