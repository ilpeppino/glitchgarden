using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderWeapon : MonoBehaviour
{
    [SerializeField] float damagePoints = 50f;
    private float weaponSpeed = 1f;

    private void Update()
    {
        transform.Translate(Vector2.right * weaponSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var _DamageManager = collision.GetComponent<DamageManager>();
        _DamageManager.Hit(damagePoints);        
    }
}
