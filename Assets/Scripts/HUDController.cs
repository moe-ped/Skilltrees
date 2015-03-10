using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour, IMessageTarget {

	// resources
	public Sprite[] icons;
	public Sprite[] inactiveIcons;
	public Sprite empty;

	// scene objects
	public GameObject skilltreeUI;

	public GameObject tooltipUI;

	public Text skillPointText;
	string originalSkillText;

	public Image dragIcon;

	public Player player;

	// yep it's ugly
	public Spell exiledContent;

	SkillbarSlot[] slots;

	void Start ()
	{
		// test
		player = new Player ();
		player.Initialize ();
		originalSkillText = skillPointText.text;
		InitializeSkilltreeUI ();
		slots = GetComponentsInChildren<SkillbarSlot>();
		InitializeSkillbarUI ();
	}

	void Update ()
	{
		updateStatsDisplay ();
		if (exiledContent != null)
		{
			dragIcon.gameObject.SetActive (true);
			dragIcon.transform.position = Input.mousePosition;
		}
	}

	void InitializeSkilltreeUI ()
	{
		SkilltreeSlot[] skilltreeSlots = GetComponentsInChildren<SkilltreeSlot>();
		// assumes that a sufficient number of slots has been created
		int i=0;
		for (int t=0; t<player.skilltrees.Length; t++)
		{
			for (int s=0; s<player.skilltrees[t].spells.Length; s++)
			{
				skilltreeSlots[i].Initialize (player.skilltrees[t].spells[s], this);
				skilltreeSlots[i].GetComponent<Image>().overrideSprite = inactiveIcons[skilltreeSlots[i].content.iconID];
				i++;
			}
		}
		skilltreeUI.SetActive (false);
	}

	void InitializeSkillbarUI ()
	{
		foreach (SkillbarSlot skillbarSlot in slots)
		{
			skillbarSlot.Initialize (null, this);
		}
	}

	public void addSkill (Spell spell)
	{
		foreach (Slot slot in slots)
		{
			if (slot.content == null)
			{
				slot.Initialize(spell, this);
				slot.GetComponent<Image>().overrideSprite = icons[slot.content.iconID];
				return;
			}
		}
	}

	public void addSkill (Spell spell, Slot slot)
	{
		exiledContent = null;
		if (slot.content != null)
		{
			Debug.Log (":(");
			exiledContent = slot.content;
			dragIcon.overrideSprite = icons[slot.content.iconID];
		}
		slot.Initialize(spell, this);
		slot.GetComponent<Image>().overrideSprite = icons[slot.content.iconID];
	}

	public void removeSkill (Slot slot)
	{
		slot.content = null;
		slot.GetComponent<Image>().overrideSprite = empty;
	}

	public void changeDragIcon (int id)
	{
		dragIcon.overrideSprite = icons[id];
	}

	// only for skill points for now
	void updateStatsDisplay ()
	{
		skillPointText.text = originalSkillText.Replace ("$sp", player.skillPoints.ToString());
	}

	#region IMessageTarget implementation

	// give name that impies toggle functionality?
	public void OnOpenSkilltrees ()
	{
		skilltreeUI.SetActive (!skilltreeUI.activeSelf);
	}

	public void OnShowTooltip ()
	{
		tooltipUI.SetActive (true);
	}

	public void OnHideTooltip ()
	{
		tooltipUI.SetActive (false);
	}

	#endregion
}
