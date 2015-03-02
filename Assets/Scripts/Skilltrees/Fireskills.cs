using UnityEngine;
using System.Collections;

public class Fireskills : Skilltree {

	public Fireskills () {
		spells = new Spell[6];
		
		spells [0] = new Fireball ();
		spells [1] = new Fireball ();
		spells [2] = new Fireball ();
		spells [3] = new Fireball ();
		spells [4] = new Fireball ();
		spells [5] = new Fireball ();
	}
}
