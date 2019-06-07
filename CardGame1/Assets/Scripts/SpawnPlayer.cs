using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player; 
    public GameObject playerP;

    void Awake()
    {
       Object.Instantiate(player,playerP.transform);
    }

}
