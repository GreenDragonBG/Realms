using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{	
	public static bool isTurn = true;
	public Transform parentToReturnTo = null;

	public void OnBeginDrag(PointerEventData eventData){
		//Debug.Log("OnBeginDrag");
		if (isTurn)
		{
		parentToReturnTo = this.transform.parent;
		this.transform.SetParent(parentToReturnTo.parent);
		GetComponent<CanvasGroup>().blocksRaycasts = false;
		
		//glow on PickUp
		DropZone[] zones = GameObject.FindObjectsOfType<DropZone>();
		foreach(DropZone z in zones){
			if(z.CompareTag(this.tag)){
				Color  color = z.GetComponent<Image>().color;
				color.a = 0.6f;
				z.GetComponent<Image>().color = color;
			}

		}
		}

	}

	public void OnDrag(PointerEventData eventData){
		//Debug.Log(parentToReturnTo.name);
		if (isTurn)
		{
		this.transform.position = eventData.position;
		}

	}

	 public void OnEndDrag(PointerEventData eventData){
		//Debug.Log("OnEndDrag");
		if (isTurn)
		{
			this.transform.SetParent(parentToReturnTo);
		GetComponent<CanvasGroup>().blocksRaycasts = true;

		//stop glow on Drop
		DropZone[] zones = GameObject.FindObjectsOfType<DropZone>();
		foreach(DropZone z in zones){
			if(z.CompareTag(this.tag)){
				Color  color = z.GetComponent<Image>().color;
				color.a = 0.2f;
				z.GetComponent<Image>().color = color;
			}

		}
		}
	 }

	 public void SetIsTurn(bool input)
	 {
		 Draggable.isTurn = input;
	 }
}
