using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DropCard : MonoBehaviour, IDropHandler
{
    public GameObject pointsTXT;
    void Start() {
        pointsTXT = GameObject.Find("Points");
    }
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Debug.Log("Nombre de objecto tomado " + eventData.pointerDrag.name);
        Debug.Log("Nombre del objecto donde cayó " + this.transform.name);
        //Vereficamos si es una carta o un campo
        if(returnTransformData()!=null)
        {   //player vs enemies
            if(returnEventData().typeCard == CardInfo.CardType.Player && returnTransformData().typeCard==CardInfo.CardType.Enemy)
            {
                returnEventData().hp = returnEventData().hp - returnTransformData().hp;
                returnTransformData().hp = returnTransformData().hp - returnEventData().hp;
            }
            //Potion en jugador
            else if (returnEventData().typeCard == CardInfo.CardType.Utility && returnTransformData().typeCard == CardInfo.CardType.Player)
            {
                if(returnTransformData().hp< returnTransformData().genHP)
                {
                    returnTransformData().hp = returnTransformData().hp + returnEventData().hp;
                    if(returnTransformData().hp >= returnTransformData().genHP)
                    {
                        returnTransformData().hp = returnTransformData().genHP;
                    }
                    returnEventData().hp = 0; 
                }
            }
            //Jugador en potion
            else if (returnEventData().typeCard == CardInfo.CardType.Player && returnTransformData().typeCard == CardInfo.CardType.Utility)
            {
                if(returnEventData().hp < returnEventData().genHP)
                {
                    returnEventData().hp = returnEventData().hp + returnTransformData().hp;
                    if(returnEventData().hp >= returnEventData().genHP)
                    {
                        returnEventData().hp = returnEventData().genHP;
                    }
                    returnTransformData().hp = 0;
                }
            }
        }
        else
        {
            //Poner potion desde field a inventario
            if(returnEventData().typeCard == CardInfo.CardType.Utility && this.transform.name == GameObject.Find("PotionField").name)
            {
                
                if(this.transform.childCount==1)
                {
                    eventData.pointerDrag.GetComponent<DragNDrop>().parentReturn = this.transform;
                }
            }
            //vender pociones por puntos
            if(returnEventData().typeCard == CardInfo.CardType.Utility && this.transform.name == GameObject.Find("VentaPuntos").name)
            {
                pointsTXT.GetComponent<PointSystem>().points = pointsTXT.GetComponent<PointSystem>().points + 1;
                returnEventData().hp = 0;
            }
        }
        //metodos datos
        CardLoader returnEventData()
        {
            return eventData.pointerDrag.GetComponent<CardLoader>();
        }
        CardLoader returnTransformData()
        {
            return this.transform.GetComponent<CardLoader>();
        }
    }
}
