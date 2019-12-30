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

    public void AddStars(int amount)
    {
        FindObjectOfType<StarManager>().AddStars(amount);
        Debug.Log("Caller Defender.cs - AddStars method");
    }

    public void SpendStars(int amount)
    {
        FindObjectOfType<StarManager>().SpendStars(amount);
        Debug.Log("Caller Defender.cs - SpendStars method");
    }


}
