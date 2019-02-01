﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvicibilityPowerUp : MonoBehaviour
{
    public GameObject energyExplosion;

    void Update()
    {
        //Rotate PowerUp.
        transform.Rotate(new Vector3(5, 95, 5) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            //Make Object Invincible.
            GetComponent<MeshRenderer>().enabled = false;

            //Create VFX Effects.
            Instantiate(energyExplosion, transform.position, transform.rotation);

            //Apply Invicibility.
            

            //Destroy Object.
            Destroy(this);
        }
    }
}
