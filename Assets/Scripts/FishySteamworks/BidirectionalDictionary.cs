namespace FishySteamworks
{
	public class BidirectionalDictionary<T1, T2> : global::System.Collections.IEnumerable
	{
		private global::System.Collections.Generic.Dictionary<T1, T2> t1ToT2Dict;

		private global::System.Collections.Generic.Dictionary<T2, T1> t2ToT1Dict;

		public global::System.Collections.Generic.IEnumerable<T1> FirstTypes => null;

		public global::System.Collections.Generic.IEnumerable<T2> SecondTypes => null;

		public int Count => 0;

		public global::System.Collections.Generic.Dictionary<T1, T2> First => null;

		public global::System.Collections.Generic.Dictionary<T2, T1> Second => null;

		public T1 this[T2 key]
		{
			get
			{
				return default(T1);
			}
			set
			{
			}
		}

		public T2 this[T1 key]
		{
			get
			{
				return default(T2);
			}
			set
			{
			}
		}

		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		public void Add(T1 key, T2 value)
		{
		}

		public void Add(T2 key, T1 value)
		{
		}

		public T2 Get(T1 key)
		{
			return default(T2);
		}

		public T1 Get(T2 key)
		{
			return default(T1);
		}

		public bool TryGetValue(T1 key, out T2 value)
		{
			value = default(T2);
			return false;
		}

		public bool TryGetValue(T2 key, out T1 value)
		{
			value = default(T1);
			return false;
		}

		public bool Contains(T1 key)
		{
			return false;
		}

		public bool Contains(T2 key)
		{
			return false;
		}

		public void Remove(T1 key)
		{
		}

		public void Remove(T2 key)
		{
		}
	}
}
