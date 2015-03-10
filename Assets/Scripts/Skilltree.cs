using UnityEngine;
using System.Collections;

public class Skilltree 
{
	protected Spell[] _spells;

	public virtual void Initialize()
	{
	
	}

	public virtual void Update()
	{

	}

	public Spell[] spells
	{
		get 
		{
			return _spells;
		}
	}
}
