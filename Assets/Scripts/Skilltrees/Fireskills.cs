using UnityEngine;
using System.Collections;

public class Fireskills : Skilltree {

	public override void Initialize()
	{
		_spells = new Spell[6];
		
		_spells [0] = new Fireball ();
		_spells [1] = new Fireball1 ();
		_spells [2] = new Firebeam ();
		_spells [3] = new Firebeam1 ();
		_spells [4] = new Firecomet ();
		_spells [5] = new Fireshield ();

		foreach (Spell spell in _spells)
		{
			spell.Initialize ();
		}
	}
}
