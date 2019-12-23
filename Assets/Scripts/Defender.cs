using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] GameObject defenderWeapon, defenderGun;



    public void Shoot()
    {
        Instantiate(defenderWeapon, defenderGun.transform.position, transform.rotation);
        return;
    }
}
