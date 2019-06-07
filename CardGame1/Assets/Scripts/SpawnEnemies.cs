using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemySpawn;

    public void Spawner()
    {
        if(Mathf.Round(Random.Range(0,10))>=5)
            {
                enemySpawn.GetComponent<CardLoader>().cardinfo =Resources.Load<CardInfo>("Cards/Enemies/Goblin");
            }
            else
            {
                enemySpawn.GetComponent<CardLoader>().cardinfo =Resources.Load<CardInfo>("Cards/Enemies/Slime");

            }
            Object.Instantiate(enemySpawn, transform);
    }
}
