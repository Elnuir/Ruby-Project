﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public ParticleSystem HealthBurst;
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
                controller.PlaySound(collectedClip);
                Instantiate(HealthBurst, transform.position, Quaternion.identity);
            }
        }
    }
}
