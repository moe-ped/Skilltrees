using UnityEngine;
using System.Collections;

public class Fireskills : Skilltree {

	public Fireskills () {
		spells = new Spell[6];
		
		spells [0] = new Fireball ();
		spells [1] = new FlameOrb ();
		spells [2] = new EarthQuake ();
		spells [3] = new Eruption ();
		spells [4] = new LightningBold ();
		spells [5] = new ThunderShock ();
	}
}
