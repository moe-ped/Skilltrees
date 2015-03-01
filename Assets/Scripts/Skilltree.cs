using UnityEngine;
using System.Collections;

public class Skilltree {

	protected Spell[] spells;

	public virtual void Update(){
		if (spells == null) {
			return;
		}
		foreach (Spell spell in spells) {
			spell.Update();
		}
	}
}
