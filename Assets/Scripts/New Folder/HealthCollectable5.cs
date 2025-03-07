﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        controller5 controller = other.GetComponent<controller5>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
                controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
