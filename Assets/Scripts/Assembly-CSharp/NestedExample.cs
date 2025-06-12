using System;
using Malee.List;
using UnityEngine;

public class NestedExample : MonoBehaviour
{
	[Serializable]
	public class ExampleChild
	{
		[Reorderable(singleLine = true)]
		public NestedChildList nested;
	}

	[Serializable]
	public class NestedChild
	{
		public float myValue;
	}

	[Serializable]
	public class NestedChildCustomDrawer
	{
		public bool myBool;

		public GameObject myGameObject;
	}

	[Serializable]
	public class ExampleChildList : ReorderableArray<ExampleChild>
	{
	}

	[Serializable]
	public class NestedChildList : ReorderableArray<NestedChildCustomDrawer>
	{
	}

	[Reorderable]
	public ExampleChildList list;
}
