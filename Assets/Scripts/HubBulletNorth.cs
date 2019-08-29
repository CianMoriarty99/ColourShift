using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubBulletNorth : MonoBehaviour
{

    public float speed = 1f;
    public Rigidbody2D rb;
    private Vector3 moveDir;
    private Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {

         pos = new Vector3(0f,4f,0f);
 
        Vector3 moveDir = (pos - transform.position).normalized;
        rb.velocity = moveDir * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    { 
        Debug.Log(hitInfo.gameObject.tag);
        //Debug.Log(this.tag);
        if (hitInfo.gameObject.tag == this.tag) 
        {
            Destroy (gameObject);
            if (FindObjectOfType<GameManager>().gameHasEnded == false) 
            {
                Score.scoreInt += 1;
            }
        }

    }
}
