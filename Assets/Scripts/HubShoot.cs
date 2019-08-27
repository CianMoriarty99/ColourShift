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
    void Update()
    {
        if (levelDifficulty < 2)
            levelDifficulty = 2;

        if (shotTimer > 0)
            shotTimer -= Time.deltaTime;

        if (shotTimer < 0)
            shotTimer = 0;

        if (shotTimer == 0) {
            Fire();

        //int range =  Random.Range(1,11);
        //if (range < )
        shotCooldown = Random.Range(1.5f*levelDifficulty,2f*levelDifficulty);
        shotTimer = shotCooldown;
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
        levelDifficulty -= 0.4f;
    }
}
