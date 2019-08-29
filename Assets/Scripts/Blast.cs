using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletCirclePrefab;
    public GameObject bulletSquarePrefab;

    public Sprite circleSprite;
    public Sprite squareSprite;

    public Animator animator;
 


    public bool blue;


    // Start is called before the first frame update
    void Start()
    {
        blue = false;
        this.GetComponent<SpriteRenderer>().sprite = circleSprite;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Blue", blue);   

        if (Input.GetKeyDown("up"))
        {
            Shoot();
        }

        if (Input.GetKeyDown("down"))
        {
            blue = !blue; //Toggle
        }


        // if (blue)
        // {
        //     this.GetComponent<SpriteRenderer>().sprite = circleSprite;
        // }
        // else 
        // {
        //     this.GetComponent<SpriteRenderer>().sprite = squareSprite;
        // }
    }

    void Shoot()
    {
        if (blue) {
        Instantiate(bulletCirclePrefab, firePoint.position, firePoint.rotation);
        }
        else {
        Instantiate(bulletSquarePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
