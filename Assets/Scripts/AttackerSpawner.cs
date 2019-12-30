using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] bool canSpawn = true;

    [SerializeField] Attacker typeOfAttackerToSpawn;
    [SerializeField] float minimumSpawningTime = 0.4f;
    [SerializeField] float maximumSpawningTime = 1f;


    private float deltaYPos = 0.3f;


    IEnumerator Start()
    {
        while (canSpawn)
        {
            
            yield return new WaitForSeconds(UnityEngine.Random.Range(minimumSpawningTime, maximumSpawningTime));
            SpawnAttacker();
        } 
    }

    private void SpawnAttacker()
    {

        Attacker newAttacker = Instantiate(
            typeOfAttackerToSpawn, 
            new Vector2(transform.position.x, 
            Mathf.Round(UnityEngine.Random.Range(1, 6))+ deltaYPos), 
            transform.rotation) 
            as Attacker;

        // when attacker are spawn, they will be instantiate under the parent (lane)
        newAttacker.transform.parent = transform;
    }

}
