using UnityEngine;
using System.Collections;

public class Iceskills : Skilltree {

	public Iceskills () {
		spells = new Spell[4];
		
		spells [0] = new Blizzard ();
		spells [1] = new HunterCrawl ();
		spells [2] = new IceStorm ();
		spells [3] = new RangerSneak ();
	}
}
