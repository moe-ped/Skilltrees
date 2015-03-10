using UnityEngine;
using System.Collections;

public abstract class Spell  
{

	protected int _spCost;
	protected int _sp;

	protected int _iconID;

	public virtual void Initialize()
	{
		_spCost = 3;
		_sp = 0;
		_iconID = 0;
	}

	public virtual void Destroy()
	{

	}

	public int spCost
	{
		get
		{
			return _spCost;
		}
	}

	public int sp
	{
		get
		{
			return _sp;
		}
		set
		{
			_sp = value;
		}
	}
	public int iconID
	{
		get
		{
			return _iconID;
		}
	}

}
