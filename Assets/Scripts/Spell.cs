using UnityEngine;
using System.Collections;

public abstract class Spell  
{

	protected int _spCost;
	protected int _sp;

	protected Sprite _icon;

	public virtual void Initialize(Sprite icon)
	{
		_spCost = 3;
		_sp = 0;
		_icon = icon;
	}

	public virtual void Destroy()
	{

	}
}
