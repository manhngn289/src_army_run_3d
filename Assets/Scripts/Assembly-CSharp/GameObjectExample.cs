using System;
using Malee.List;
using UnityEngine;

public class GameObjectExample : MonoBehaviour
{
	[Serializable]
	public class GameObjectList : ReorderableArray<GameObject>
	{
	}

	[Reorderable(paginate = true, pageSize = 2)]
	public GameObjectList list;

	private void Update()
	{
	}
}
