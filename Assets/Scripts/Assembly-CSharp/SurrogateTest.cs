using System;
using Malee.List;
using UnityEngine;

public class SurrogateTest : MonoBehaviour
{
	[Serializable]
	public class MyClass
	{
		public string name;

		public GameObject gameObject;
	}

	[Serializable]
	public class MyClassArray : ReorderableArray<MyClass>
	{
	}

	[SerializeField]
	private MyClass[] objects;

	[Reorderable(surrogateType = typeof(GameObject), surrogateProperty = "gameObject")]
	[SerializeField]
	private MyClassArray myClassArray;
}
