using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderWeapon : MonoBehaviour
{
    private float weaponSpeed = 1f;

    private void Update()
    {
        transform.Translate(Vector2.right * weaponSpeed * Time.deltaTime);

    }
}
