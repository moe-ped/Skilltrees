using UnityEngine;
using System.Collections;

public class ObjectCreator {
		
	static ObjectCreator _instance;

	private string _playerName;

	public static ObjectCreator instance{
		get
		{
			if(_instance == null)
			{
				Debug.Log("Objectcreator instance created");
				_instance = new ObjectCreator();
			}
			Debug.Log("get Instance");
			return _instance;
		}

	}

	public string playerName {
		get {
			return _playerName;
		}
		set
		{
			_playerName = value;
		}
	}

	public GameObject cube{
		get
		{
		GameObject	cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.position = new Vector3(0,0,0);
		return cube;
		}
	}

	public GameObject Sphere{
		get
		{
			GameObject	Sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			Sphere.transform.position = new Vector3(0,0,0);
			return Sphere;
		}
	}

	public GameObject Cylinder{
		get
		{
			GameObject	Cylinder = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
			Cylinder.transform.position = new Vector3(0,0,0);
			return Cylinder;
		}
	}
	
	void Update () {
	
	}
}
