namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class SerializableDictionary<K, V> : global::UnityEngine.ISerializationCallbackReceiver
	{
		[global::System.NonSerialized]
		public global::System.Collections.Generic.Dictionary<K, V> dict;

		[global::UnityEngine.SerializeField]
		public global::System.Collections.Generic.List<K> m_Keys;

		[global::UnityEngine.SerializeField]
		public global::System.Collections.Generic.List<V> m_Values;

		public V this[K aKey]
		{
			get
			{
				return default(V);
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
