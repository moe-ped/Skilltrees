using UnityEngine;
using System.Collections;

class RangerSneak : Spell {


public override void Initialize ()
	{
		_cooldowntime = 0.1f;
		_damage = 0;
	}

	public override void Update ()
	{
		Sneak ();
	} 

	void Sneak(){
		if(Input.GetMouseButtonDown(1)){
			Debug.Log("Hans-Peter mag das");
		}
	}
}
