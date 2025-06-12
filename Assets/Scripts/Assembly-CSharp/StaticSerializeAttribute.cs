using System;
using UnityEngine;

public class StaticSerializeAttribute : PropertyAttribute
{
	public string staticFieldName;

	public Type typeOfStaticField;

	public StaticSerializeAttribute(string staticField)
	{
	}

	public StaticSerializeAttribute(Type type, string staticField)
	{
	}
}
