using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class KeyframeGroupDictionary : ISerializationCallbackReceiver, IEnumerable<string>, IEnumerable
	{
		[NonSerialized]
		private Dictionary<string, IKeyframeGroup> m_Groups;

		[SerializeField]
		private ColorGroupDictionary m_ColorGroup;

		[SerializeField]
		private NumberGroupDictionary m_NumberGroup;

		[SerializeField]
		private TextureGroupDictionary m_TextureGroup;

		[SerializeField]
		private SpherePointGroupDictionary m_SpherePointGroup;

		[SerializeField]
		private BoolGroupDictionary m_BoolGroup;

		public IKeyframeGroup this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public void Clear()
		{
		}

		public T GetGroup<T>(string propertyName) where T : class
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
