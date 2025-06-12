using System;
using System.Collections.Generic;
using Malee.List;
using UnityEngine;

public class Example : MonoBehaviour
{
	[Serializable]
	public class ExampleChild
	{
		public enum ExampleEnum
		{
			EnumValue1 = 0,
			EnumValue2 = 1,
			EnumValue3 = 2
		}

		public string name;

		public float value;

		public ExampleEnum myEnum;

		public LayerMask layerMask;

		public long longValue;

		public char charValue;

		public byte byteValue;
	}

	[Serializable]
	public class ExampleChildList : ReorderableArray<ExampleChild>
	{
	}

	[Serializable]
	public class StringList : ReorderableArray<string>
	{
	}

	[Serializable]
	public class VectorList : ReorderableArray<Vector4>
	{
	}

	public List<ExampleChild> list1;

	[Reorderable]
	public ExampleChildList list2;

	[Reorderable]
	public ExampleChildList list3;

	[Reorderable]
	public StringList list4;

	[Reorderable]
	public VectorList list5;
}
