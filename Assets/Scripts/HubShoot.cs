using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HubShoot : MonoBehaviour
{

    public GameObject hubCirclePrefab;
    public GameObject hubSquarePrefab;

    public float decider;

    public Transform firePoint;

    public float levelDifficulty;

    public float shotCooldown;
    public float shotTimer;





    // Start is called before the first frame update
    void Start()
    {
        levelDifficulty = 4;   
        shotTimer = Random.Range(1f,3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (shotTimer <= 0 ) {
            shotTimer = 10;
            shotCooldown = Random.Range(0.7f,2f);
            shotTimer = shotCooldown * levelDifficulty;
            Fire();
        }

        if (levelDifficulty < 1.5f) {
            levelDifficulty = 1.5f;
        }


        if (shotTimer > 0) {
            shotTimer -= Time.deltaTime;

        }





    }



    void Fire()
    {   
        decider = Random.Range(0f,2f);
        if (decider <= 1) {
            Instantiate(hubCirclePrefab, firePoint.position, firePoint.rotation);
        }
        else {
            Instantiate(hubSquarePrefab, firePoint.position, firePoint.rotation);
        }
        levelDifficulty -= 0.15f;

    }

}
