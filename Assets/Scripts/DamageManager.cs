using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
 * USED BY
 * 
 * Prefabs/Lizard
 * 
 * **********************************************/

public class DamageManager : MonoBehaviour
{

    [SerializeField] float healthPoints = 100f;
    [SerializeField] GameObject _explosion;

    public void Hit (float damagePoints)
    {
        healthPoints = healthPoints - damagePoints;

        if (healthPoints <= 0)
        {
            DeathExplosion();
            Destroy(gameObject);
        }
    }

    private void DeathExplosion()
    {
        if(!_explosion) { return; }

        // In order to destroy the particles object, better to assign with the next statement and then destroy that object
        GameObject _explosionObject = Instantiate(_explosion, transform.position, Quaternion.identity);
        Destroy(_explosionObject, 2f);

    }
}
