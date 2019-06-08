using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DropCard : MonoBehaviour, IDropHandler
{
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Debug.Log("Nombre de objecto tomado " + eventData.pointerDrag.name);
        Debug.Log("Nombre del objecto donde cayó " + this.transform.name);
        Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
    }
}
