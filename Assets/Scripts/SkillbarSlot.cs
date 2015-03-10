using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SkillbarSlot : Slot, IDropHandler, IPointerClickHandler {

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		hudController.addSkill (eventData.pointerDrag.GetComponent<Slot>().content, this);
		if (!eventData.pointerDrag.GetComponent<SkilltreeSlot>())
		{
			hudController.removeSkill (eventData.pointerDrag.GetComponent<Slot>());
		}
	}

	#endregion

	#region IPointerClickHandler implementation

	public void OnPointerClick (PointerEventData eventData)
	{
		if (hudController.exiledContent != null)
		{
			hudController.addSkill (hudController.exiledContent, this);
			hudController.dragIcon.gameObject.SetActive (false);
		}
	}

	#endregion
}
