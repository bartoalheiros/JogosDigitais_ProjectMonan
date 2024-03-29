﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn1 : MonoBehaviour {
    public GameObject player;
    private PlayerHealth health;
    private int damage = 20;

    private void Awake() {
        health = player.GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(health.currentHealth < 1) 
        {
            return;
        } else if(health.currentHealth >= 2*damage){
            player.transform.position = new Vector3(40, 0, 0);
            
            player.GetComponent<PlayerHealth>().TakeDamage(damage, false);
        } else {
            player.GetComponent<PlayerHealth>().TakeDamage(damage, false);
        }
            
    }   

}
