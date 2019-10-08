using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletCirclePrefab;
    public GameObject bulletSquarePrefab;

    public Animator animator;

    public bool blue;
    public float coolOff;


    // Start is called before the first frame update
    void Start()
    {
        blue = false;
        coolOff = 0;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Blue", blue);   

        if (Input.GetKeyDown("up") && coolOff == 0)
        {
            coolOff = 0.1f;
            Shoot();
        }

        if (Input.GetKeyDown("down"))
        {
            blue = !blue; //Toggle
        }

        if (coolOff > 0)
            coolOff -= Time.deltaTime;


        if (coolOff < 0) 
            coolOff = 0;

    }

    void Shoot()
    {
        if (!blue) {
        Instantiate(bulletCirclePrefab, firePoint.position, firePoint.rotation);
        }
        else {
        Instantiate(bulletSquarePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
