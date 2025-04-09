using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class SerializableDictionary<K, V> : ISerializationCallbackReceiver
	{
		[NonSerialized]
		public Dictionary<K, V> dict;

		[SerializeField]
		public List<K> m_Keys;

		[SerializeField]
		public List<V> m_Values;

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
