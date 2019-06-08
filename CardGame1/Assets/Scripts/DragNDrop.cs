using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    Transform parentReturn = null;
    private GameObject FieldPotion;

    void Start() {
        FieldPotion = GameObject.Find("PotionField");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if(GetComponent<CardLoader>().typeCard == CardInfo.CardType.Utility && FieldPotion.name == this.transform.parent.name)
        {
            parentReturn = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent.parent);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        else
        {
            parentReturn = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
        this.transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentReturn);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
