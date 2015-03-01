using UnityEngine;
using System.Collections;

class Fireball : Spell {


	public override void Update(){
		//Base.Update ruft das ursprüngliche update mit dem override auf
		//base.Update ();
		/*if(_cooldowntime >= 0){
			_cooldowntime -= 0.01f;
			Debug.Log(_cooldowntime);
		}*/
	}

	public override void Initialize(){
		_cooldowntime = 3;
		_damage = 50;
		_flytime = 3;
		_spellspeed = 30;
		Debug.Log ("Initialized Properties");
	}

	public Fireball(){

		Debug.Log (_cooldowntime + " " + _damage);

		_cooldowntime = _cooldowntime * 2;

		_damage = _damage * 2;
		
		Debug.Log (_cooldowntime + " " + _damage);
	
	}
}
