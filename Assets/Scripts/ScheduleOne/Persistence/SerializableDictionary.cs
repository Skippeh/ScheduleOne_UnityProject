namespace ScheduleOne.Persistence
{
	[global::System.Serializable]
	public class SerializableDictionary<TKey, TValue> : global::UnityEngine.ISerializationCallbackReceiver, global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable
	{
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<TKey> keys;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<TValue> values;

		private global::System.Collections.Generic.Dictionary<TKey, TValue> dictionary;

		public TValue this[TKey key]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public global::System.Collections.Generic.ICollection<TKey> Keys => null;

		public global::System.Collections.Generic.ICollection<TValue> Values => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public void CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		public bool Remove(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
