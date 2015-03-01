using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using Microsoft.JScript;

public class Root : MonoBehaviour {

	Skilltree[] skilltrees;

	public List<GameObject> _primitives;
	Spell test;

	// Use this for initialization
	void Awake(){
		//Microsoft.JScript.Eval ();
		string JSource = "print('Hello, World!')";
		//Microsoft.JScript.Eval.JScriptEvaluate(JSource, Microsoft.JScript.Vsa.VsaEngine.CreateEngine());
		skilltrees = new Skilltree[2];

		//skilltrees [0] = new Fireskills ();
		//skilltrees [1] = new Iceskills ();

		test = new Fireball();
		test.Initialize();

		//doTest ();
		//this.GetType ().GetMethod ("doTest").Invoke (this, null);
		Invoke ("doTest", 0);
		//test["initialize()"];
		//test.Destroy ();
	}

	void doTest () {
		//Debug.Log ("test: " + this.GetType().GetProperty ("test").GetValue(this, null));
		Debug.Log ("TEST");
	}

	void runScript () {

	}

	void Start () {

		/*Debug.Log ("Root Called");


		_primitives = new List<GameObject>();
		ObjectCreator creator = ObjectCreator.instance;
		creator.playerName = "Hans";

		for(uint x = 1; x < 4; x++){
			for(uint y = 1; y<4; y++){
				GameObject cube = creator.cube;
				cube.transform.position = new Vector3(x*2,y*2,0);
				_primitives.Add(cube);
			}
		}

		for(uint x = 1; x < 4; x++){
			for(uint y = 1; y < 4; y++){
				GameObject Sphere = creator.Sphere;
				Sphere.transform.position = new Vector3(x*-3,y*2,0);
				_primitives.Add(Sphere);
			}
		}

		for(uint x = 1; x < 4; x++){
			for(uint y = 1; y < 4; y++){
				GameObject Cylinder = creator.Cylinder;
				Cylinder.transform.position = new Vector3(x*-1,y*-1,0);
				_primitives.Add(Cylinder);
			}
		}*/
	}
	
	// Update is called once per frame
	void Update () {


		/* foreach (GameObject Primitive in _primitives) {
			Primitive.renderer.material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0.0f,1.0f));	
		}*/
		test.Update();
		foreach (Skilltree skilltree in skilltrees) {
			//skilltree.Update();
		}
	}
}
