using UnityEngine;
using System.Collections;

// used as data storage -> call playerdata? there might be a pattern for this ...
// might just make this a gameobject (-> easier balancing, more "intuitive" scene)
//would really not go well with the way spells are implemented right now (cannot be made serializable afaik).
public class Player {

	public int skillPoints = 10;
	// test
	public Skilltree[] skilltrees;

	public void Initialize()
	{
		skilltrees = new Skilltree[2];

		skilltrees[0] = new Fireskills ();
		skilltrees[1] = new Iceskills ();

		foreach (Skilltree skilltree in skilltrees)
		{
			skilltree.Initialize ();
		}
	}
}
