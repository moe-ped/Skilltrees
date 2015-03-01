﻿using UnityEngine;
using System.Collections;

class Blizzard : Spell {

	public override void Initialize ()
	{
		_flytime = 1;
		_cooldowntime = 0.3f;
		_damage = 0;
		_spellspeed = 15;
		_type = Type.Ice;
	}
	
	public override void Update ()
	{
		Freeze ();
	} 
	
	private void Freeze(){
		if(Input.GetMouseButtonDown(1)){
			Debug.Log("Ich bin Kalt");
		}
	}
}