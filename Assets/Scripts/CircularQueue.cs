public class CircularQueue<T> where T : struct
{
	[global::Unity.Collections.ReadOnly]
	public global::Unity.Collections.NativeArray<T> q;

	private int idx;

	private int cap;

	private int length;

	public T this[int i] => default(T);

	public int Capacity => 0;

	public int Count => 0;

	public CircularQueue(int capacity)
	{
	}

	public void Enqueue(T item)
	{
	}

	public void Dequeue()
	{
	}

	public void Clear()
	{
	}

	private int modulo(int i, int m)
	{
		return 0;
	}
}
