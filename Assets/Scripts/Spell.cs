using UnityEngine;
using System.Collections;

public abstract class Spell  {

	protected float _cooldowntime ;
	protected float _damage;
	protected float _flytime;
	protected float _spellspeed;

	public enum Type{Default, Fire, Ice, Lightning, ground};

	protected Type _type;

	public virtual void Update(){
		Debug.Log ("Spell update called");
	}

	public virtual void Initialize(){
		_cooldowntime = 10;
		_damage = 100;
		_flytime = 2;
		//_type = Type.Default;
	}

	public virtual void Destroy(){
		Debug.Log ("Destroyed");
		_cooldowntime = 0;
		_damage = 0;
		_flytime = 0;
		_spellspeed = 0;
	}

}
