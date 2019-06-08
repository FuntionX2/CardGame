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
    public GameObject noName;
    
    void Start()
    {
        imagenSource = transform.GetComponent<Image>();
        nameCard = transform.Find("Name").GetComponent<TextMeshProUGUI>();
        nameCard.text = cardinfo.cardName;
        hpText = transform.Find("Image/hp").GetComponent<TextMeshProUGUI>();
        imagen = cardinfo.imagen;
        imagenSource.sprite = imagen;
        hp = cardinfo.hp;
        id = cardinfo.id;
        description = cardinfo.description;
        typeCard = cardinfo.typeCard;
        noName = transform.Find("Name").gameObject;
        if(typeCard==CardInfo.CardType.Player)
        {
            Destroy(noName);
        }
    }
    void Update() {
        hpText.text = hp.ToString();
        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }

}

