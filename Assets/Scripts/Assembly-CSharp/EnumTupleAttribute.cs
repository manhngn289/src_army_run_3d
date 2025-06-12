using System;
using UnityEngine;

public class EnumTupleAttribute : PropertyAttribute
{
	public Type EnumType1 { get; private set; }

	public Type EnumType2 { get; private set; }

	public string Label1 { get; private set; }

	public string Label2 { get; private set; }

	public EnumTupleAttribute(Type enumType1, Type enumType2, string label1 = "Item1", string label2 = "Item2")
	{
	}
}
