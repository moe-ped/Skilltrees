using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	public Spell content;

	protected HUDController hudController;

	// should have done stuff like p_player ...
	public void Initialize (Spell spell, HUDController hudControllerRef)
	{
		content = spell;
		hudController = hudControllerRef;
	}

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		hudController.dragIcon.gameObject.SetActive (true);
		hudController.changeDragIcon(content.iconID);
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		hudController.dragIcon.gameObject.SetActive (false);
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		hudController.dragIcon.transform.position = Input.mousePosition;
	}

	#endregion
}
