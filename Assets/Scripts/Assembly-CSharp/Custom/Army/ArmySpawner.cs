using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArmySpawner : MonoBehaviour
{
	[Serializable]
	public struct Unit
	{
		public GameObject prefab;

		public int count;

		public float delay;

		public bool loop;
	}

	private static Dictionary<int, Stack<GameObject>> _pool;

	public Vector2 spawnSize;

	public Vector3 sizeMult;

	public Unit[] units;

	[IteratorStateMachine(typeof(_003CStart_003Ed__5))]
	private IEnumerator Start()
	{
		return null;
	}

	private GameObject LoadFromPool(Unit unit)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
