using System;
using Malee.List;
using UnityEngine;

public class NameOverride : MonoBehaviour
{
	[Serializable]
	public class ExampleChild
	{
		[Reorderable(null, "Car Part", null)]
		public StringList nested;
	}

	[Serializable]
	public class DynamicExampleChild
	{
		[Reorderable]
		public StringList nested;
	}

	[Serializable]
	public class ExampleChildList : ReorderableArray<ExampleChild>
	{
	}

	[Serializable]
	public class DynamicExampleChildList : ReorderableArray<DynamicExampleChild>
	{
	}

	[Serializable]
	public class StringList : ReorderableArray<string>
	{
	}

	public string nameOverride;

	public string nestedNameOverride;

	[Reorderable(null, "Car", null)]
	public ExampleChildList autoNameList;

	[Reorderable]
	public DynamicExampleChildList dynamicNameList;
}
