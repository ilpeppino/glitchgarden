using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
 * USED BY
 * 
 * Prefabs/Zucchini
 * 
 * **********************************************/

public class DefenderWeapon : MonoBehaviour
{
    [SerializeField] float damagePoints = 50f;
    [SerializeField] float weaponSpeed = 5f;

    private void Update()
    {
        // The weapon goes always left to right from the defender's hands
        transform.Translate(Vector2.right * weaponSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When the defender weapon collides the attacker, it will inflict damage 
        var _damageManager = collision.GetComponent<DamageManager>();
        var _attacker = collision.GetComponent<Attacker>();

        if (_attacker && _damageManager)
        {
            _damageManager.Hit(damagePoints);

            // After the collision, the defender weapon gets destroyed
            Destroy(gameObject);
        }

    }
}
