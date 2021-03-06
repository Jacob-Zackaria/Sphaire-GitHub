﻿using UnityEngine;
using UnityEngine.UI;

public class HealthPowerUp : MonoBehaviour
{
    public Slider playerHealthbar;
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


            //Apply Health.
            playerHealthbar.value -= 0.6f;

            //Destroy Object.
            Destroy(gameObject);
        }
    }
        
}
