using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour, IMessageTarget {

	public GameObject skilltreeUI;

	#region IMessageTarget implementation

	public void OnOpenSkilltrees ()
	{
		skilltreeUI.SetActive (!skilltreeUI.activeSelf);
	}

	#endregion
}
