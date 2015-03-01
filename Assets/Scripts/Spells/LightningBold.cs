using UnityEngine;
using System.Collections;

class LightningBold :Spell {
	public override void Initialize ()
	{
		_damage = 5;
		_flytime = 3;
		_spellspeed = 10;
		_cooldowntime = 3;
	}

	public override void Update ()
	{
		base.Update ();
		Paralyse ();
	}

	void Paralyse(){
		Debug.Log ("ich bin Paralysiert....");
	}

}
