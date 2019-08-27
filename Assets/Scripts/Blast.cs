using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletCirclePrefab;
    public GameObject bulletSquarePrefab;

    public Sprite circleSprite;
    public Sprite squareSprite;
 


    public bool circ;


    // Start is called before the first frame update
    void Start()
    {
        circ = true;
        this.GetComponent<SpriteRenderer>().sprite = circleSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            Shoot();
        }

        if (Input.GetKeyDown("down"))
        {
            circ = !circ; //Toggle
        }


        if (circ)
        {
            this.GetComponent<SpriteRenderer>().sprite = circleSprite;
        }
        else 
        {
            this.GetComponent<SpriteRenderer>().sprite = squareSprite;
        }
    }

    void Shoot()
    {
        if (circ) {
        Instantiate(bulletCirclePrefab, firePoint.position, firePoint.rotation);
        }
        else {
        Instantiate(bulletSquarePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
