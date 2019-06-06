using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;
using TMPro;

public class CardLoader : MonoBehaviour
{

    public CardInfo cardinfo;
    public int id;
    public TextMeshProUGUI nameCard;
    public TextMeshProUGUI hpText;
    public string description;
    public Image imagenSource;
    public Sprite imagen;
    public CardInfo.CardType typeCard;
    public int hp;
    
    void Start()
    {
        imagenSource = transform.GetComponent<Image>();
        nameCard = transform.Find("Name").GetComponent<TextMeshProUGUI>();
        hpText = transform.Find("Image/hp").GetComponent<TextMeshProUGUI>();
        hp = cardinfo.hp;
        id = cardinfo.id;
        nameCard.text = cardinfo.cardName;
        description = cardinfo.description;
        imagen = cardinfo.imagen;
        imagenSource.sprite = imagen;
        typeCard = cardinfo.typeCard;

    }
    void Update() {
        hpText.text = hp.ToString();
    }

}

