using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    private Vector3 moveDir;
    private Vector3 hub;

    public Animator animator;

    public bool explode;

    void Start()
    {
        explode = false;
        hub = new Vector3(0f, 0f, 0f);
        moveDir = (hub - transform.position).normalized;
        rb.velocity = moveDir * speed;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("explode", explode);
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    { 
        
        if (hitInfo.gameObject.tag == "Hub") {
        FindObjectOfType<GameManager>().EndGame();
        }
        if (hitInfo.gameObject.tag != "Position"){
        explode = true;
        rb.velocity = moveDir * 0;
        GetComponent<CircleCollider2D> ().enabled = false;
        StartCoroutine(DestroyWaiter(0.25f));
        }
    }

    IEnumerator DestroyWaiter(float waitTime)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        Debug.Log("Destroy");
        Destroy(this.gameObject);
    
    }

}
