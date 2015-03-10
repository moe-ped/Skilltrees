using UnityEngine;
using System.Collections;

public class Iceskills : Skilltree {

	public override void Initialize()
	{
		_spells = new Spell[6];
		
		_spells [0] = new Snowflakes ();
		_spells [1] = new Glacier ();
		_spells [2] = new Icearmor ();
		_spells [3] = new Frostnova ();
		_spells [4] = new Icegolem ();
		_spells [5] = new Drmanhattan ();

		foreach (Spell spell in _spells)
		{
			spell.Initialize ();
		}
	}
}
