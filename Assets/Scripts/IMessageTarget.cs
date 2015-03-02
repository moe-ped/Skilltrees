using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IMessageTarget : IEventSystemHandler 
{
	// functions that can be called via the messaging system
	void OnOpenSkilltrees();
}
