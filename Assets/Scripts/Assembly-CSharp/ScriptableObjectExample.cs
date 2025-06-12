using System;
using Malee.List;
using UnityEngine;

[CreateAssetMenu(fileName = "New ScriptableObject Example", menuName = "ScriptableObject Example")]
public class ScriptableObjectExample : ScriptableObject
{
	[Serializable]
	private struct MyObject
	{
		public bool myBool;

		public float myValue;

		public string myString;

		public MyObject(bool myBool, float myValue, string myString)
		{
			this.myBool = false;
			this.myValue = 0f;
			this.myString = null;
		}
	}

	[Serializable]
	private class MyList : ReorderableArray<MyObject>
	{
	}

	[SerializeField]
	[Reorderable(paginate = true, pageSize = 0, elementNameProperty = "myString")]
	private MyList list;
}
