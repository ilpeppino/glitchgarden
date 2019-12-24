using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] bool canSpawn = true;

    [SerializeField] Attacker typeOfAttackerToSpawn;
    [SerializeField] int numberAttackersPerWave;
    [SerializeField] float minimumSpawningTime = 0.4f;
    [SerializeField] float maximumSpawningTime = 1f;
    [SerializeField] int timeBetweenWaves;

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
        Instantiate(typeOfAttackerToSpawn, new Vector2(transform.position.x, Mathf.Round(UnityEngine.Random.Range(minimumSpawningTime, maximumSpawningTime))+ deltaYPos), transform.rotation);
    }

}
