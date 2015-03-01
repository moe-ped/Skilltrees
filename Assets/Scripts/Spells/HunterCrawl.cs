using UnityEngine;
using System.Collections;

 class HunterCrawl : Spell {


public override void Initialize ()
	{
		_cooldowntime = 0.1f;
		_damage = 0;
	}

	public override void Update ()
	{
		Crawl ();
	} 

	void Crawl(){
		if(Input.GetMouseButtonDown(1)){
			Debug.Log("Hans mag das");
		}
	}
}
