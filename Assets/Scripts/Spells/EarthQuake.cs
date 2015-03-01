using UnityEngine;
using System.Collections;

class EarthQuake : Spell {

	public override void Initialize ()
	{
		_cooldowntime = 0.1f;
		_damage = 0;
	}
	
	public override void Update ()
	{
		base.Update ();
		Quake ();
	} 
	
	void Quake(){
			Debug.Log("Es Bebt");
	}
}
