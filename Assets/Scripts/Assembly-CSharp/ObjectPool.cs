using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : Component
{
	private GameObject poolContainer;

	private List<T> pool;

	private T prefab;

	public bool isLimit;

	public int limit;

	public List<T> GetPool()
	{
		return null;
	}

	public ObjectPool(T prefab, int amount, Transform poolContainerParent)
	{
	}

	public ObjectPool(T prefab, int amount, Transform poolContainerParent, bool isLimit, int limit)
	{
	}

	public T Get()
	{
		return null;
	}

	private T Create()
	{
		return null;
	}

	public void Release(T t)
	{
	}

	public void ReleaseAll(bool isCullDespawned = false)
	{
	}

	private void CullDespawnOverLimit()
	{
	}
}
