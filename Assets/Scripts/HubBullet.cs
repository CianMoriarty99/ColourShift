using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubBullet : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rb;
    private Vector3 moveDir;
    private Vector3 pos;
    private Vector3 position1;
    private Vector3 position2;
    private Vector3 position3;

    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(1, 4);

         position1 = new Vector3(0f,4f,0f);
         position2 = new Vector3(-4f,-3f,0f);
         position3 = new Vector3(4f,-3f,0f);

        Debug.Log(num);
        if (num == 1)
            pos = position1;
        if (num == 2)
            pos = position2;
        if (num == 3)
            pos = position3;
 
        Vector3 moveDir = (pos - transform.position).normalized;
        rb.velocity = moveDir * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    { 
        //Debug.Log(hitInfo.name);
        Destroy (gameObject);
    }
}
