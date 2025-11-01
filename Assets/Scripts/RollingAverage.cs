public class RollingAverage<T>
{
	private readonly T[] buffer;

	private readonly global::System.Func<T, T, T> add;

	private readonly global::System.Func<T, T, T> sub;

	private readonly global::System.Func<T, float, T> div;

	private int head;

	private int count;

	private T sum;

	public T Average => default(T);

	public int Count => 0;

	public int Capacity => 0;

	public RollingAverage(int capacity, global::System.Func<T, T, T> add, global::System.Func<T, T, T> sub, global::System.Func<T, float, T> div)
	{
	}

	public void Add(T value)
	{
	}

	public void Clear()
	{
	}
}
