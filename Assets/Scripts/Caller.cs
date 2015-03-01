using UnityEngine;
using System.Collections;

public class Caller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Caller Called");
		Debug.Log (ObjectCreator.instance.playerName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
