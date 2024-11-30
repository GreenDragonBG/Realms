using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData){
        //Debug.Log("OnPointerEnter");
    }
    public void OnPointerExit(PointerEventData eventData){
       // Debug.Log("OnPointerExit");
    }

    public void OnDrop(PointerEventData eventData){
        //Debug.Log(eventData.pointerDrag.name + "was dropped to "+ gameObject.name);
        Draggable card = eventData.pointerDrag.GetComponent<Draggable>();
       
        if(card != null && this.transform.childCount < 1){
             if(this.transform.parent.name=="PlayerZones" && card.parentToReturnTo.name =="Hand" && this.CompareTag(card.tag) 
                || card.parentToReturnTo.parent.name =="PlayerZones" && this.CompareTag(card.tag)
                || card.parentToReturnTo.parent.name =="PlayerZones" && this.CompareTag("Hand"))
             {
                card.parentToReturnTo = this.transform;
             }
        }
    }
}
