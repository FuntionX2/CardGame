using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
[CreateAssetMenu(fileName = "New card", menuName = "Card")]
public class CardInfo : ScriptableObject
{
    public enum CardType
    {
        Enemy,
        Player,
        Weapon,
        Utility
    }
    public int id;
    public string cardName;
    public string description;

    public Sprite imagen;


}
