using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotions : MonoBehaviour
{
    public GameObject potionSpawn;

   public void Spawner()
    {
        potionSpawn.GetComponent<CardLoader>().cardinfo =Resources.Load<CardInfo>("Cards/Utility/Potions/HealthPotion");
        Object.Instantiate(potionSpawn, transform);
    }
}
