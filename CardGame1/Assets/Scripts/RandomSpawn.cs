using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    private string pickRandom;
    private string[] randomPick = {CardInfo.CardType.Enemy.ToString(),CardInfo.CardType.Enemy.ToString(),CardInfo.CardType.Enemy.ToString(),CardInfo.CardType.Utility.ToString()};
    private int lenght=0;
    private int result;
    public GameObject pointsTXT;
    void Start()
    {
        Debug.Log(randomPick.Length.ToString());
        pointsTXT = GameObject.Find("Points");
        //1-Enemy 2-Potion
        Spawn();

    }
    void Update()
    {   if(transform.childCount==0)
        {
            pointsTXT.GetComponent<PointSystem>().points = pointsTXT.GetComponent<PointSystem>().points + 1;
        }
        Spawn();
    }
    void Spawn()
    {
        if(transform.childCount==0)
        {
            for (int i = 0; i < randomNumberField(); i++)
            {
                if(returnRandom(randomPick).Equals("Utility"))
                {
                    gameObject.GetComponent<SpawnPotions>().Spawner();
                }
                else
                {
                    gameObject.GetComponent<SpawnEnemies>().Spawner();   
                }
            }
        }
    }
    string returnRandom(string[] randomPick)
    {
        lenght = randomPick.Length;
        int Index = Random.Range(0,lenght);
        Debug.Log(Index.ToString());
        string thing;
        thing = randomPick[Index];
        return thing;
    }
    int randomNumberField()
    {
        int thing=0;
        float randomM = Random.value;
        if(randomM<=.5f)
        {
            thing = 2;
        }
        if(randomM<=.8f)
        {
            thing = 3;
        }
        if(randomM<=.9f)
        {
            thing = 4;
        }
        else
        {
            thing = 1;
        }
        return thing;
    }
}

