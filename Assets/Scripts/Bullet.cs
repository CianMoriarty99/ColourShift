using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    private Vector3 moveDir;
    private Vector3 hub;

    // Start is called before the first frame update
    

    void Start()
    {
        hub = new Vector3(0f, 0f, 0f);
        moveDir = (hub - transform.position).normalized;
        rb.velocity = moveDir * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    { 
        if (hitInfo.gameObject.tag == "Hub") {
        FindObjectOfType<GameManager>().EndGame();
        }
        if (hitInfo.gameObject.tag != "Position"){
        Destroy (gameObject);
        }
    }
}
