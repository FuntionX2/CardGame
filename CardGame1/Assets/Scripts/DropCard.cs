using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DropCard : MonoBehaviour, IDropHandler
{
    private CardLoader takeInfo;
    public GameObject player;
    private CardLoader playerInfo;
    private TextMeshProUGUI hp;
    
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        player = GameObject.Find("Player(Clone)");
        takeInfo = gameObject.transform.GetComponent<CardLoader>();
        if(takeInfo.typeCard == CardInfo.CardType.Enemy)
        {
            playerInfo = player.gameObject.GetComponent<CardLoader>();
            playerInfo.hp = playerInfo.hp - takeInfo.hp;
            takeInfo.hp = takeInfo.hp - playerInfo.hp;
        }
        if(takeInfo.typeCard == CardInfo.CardType.Utility)
        {
            playerInfo = player.gameObject.GetComponent<CardLoader>();
            playerInfo.hp = playerInfo.hp + takeInfo.hp;
            takeInfo.hp = takeInfo.hp-playerInfo.hp;
        }
    }
}
