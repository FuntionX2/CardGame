using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    Transform parentReturn = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentReturn = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentReturn);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
