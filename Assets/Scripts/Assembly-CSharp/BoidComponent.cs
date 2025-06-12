using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoidComponent : MonoBehaviour
{
	public float speed;

	private Quaternion velocity;

	[IteratorStateMachine(typeof(_003CStart_003Ed__2))]
	private IEnumerator Start()
	{
		return null;
	}

	private void UpdateTarget()
	{
	}

	private void Update()
	{
	}
}
