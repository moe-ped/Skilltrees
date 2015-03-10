using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkilltreeSlot : Slot, IPointerClickHandler
{
	public Text skillPointText;
	string originalSkillText;

	void Start ()
	{
		originalSkillText = skillPointText.text;
	}
	
	void Update () 
	{
		updateStatsDisplay ();
	}

	void updateStatsDisplay ()
	{
		skillPointText.text = originalSkillText.Replace ("$sp", content.sp.ToString());
		skillPointText.text = skillPointText.text.Replace ("$maxsp", content.spCost.ToString());
	}

	#region IPointerClickHandler implementation
	
	public void OnPointerClick (PointerEventData eventData)
	{
		// on greyscale effect: one COULD write a shader for that ... going to use extra images for now though (because it doesn't take forever)
		if (content.sp < content.spCost && hudController.player.skillPoints > 0)
		{
			content.sp++;
			hudController.player.skillPoints--;
			// unlock skill
			if (content.sp >= content.spCost)
			{
				hudController.addSkill (content);
				GetComponent<Image>().overrideSprite = hudController.icons[content.iconID];
			}
		}
	}
	
	#endregion
}
