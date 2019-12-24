using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{

    [SerializeField] float healthPoints = 100f;

    public void Hit (float damagePoints)
    {
        healthPoints = healthPoints - damagePoints;

        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
