
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public float ShotTime;
    public GameObject bullet;
    public Transform bulletOrigin;

    void Start()
    {
        Shot();
    }


    void Shot()
    {
       Instantiate(bullet, bulletOrigin.position, bulletOrigin.rotation);
       Invoke("Shot", ShotTime);

    }


  
    
}
