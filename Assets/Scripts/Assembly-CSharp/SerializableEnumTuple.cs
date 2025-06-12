using System;

[Serializable]
public class SerializableEnumTuple<T1, T2> where T1 : Enum where T2 : Enum
{
	public T1 item1;

	public T2 item2;

	public SerializableEnumTuple(T1 item1, T2 item2)
	{
	}

	public Tuple<T1, T2> ToTuple()
	{
		return null;
	}
}
