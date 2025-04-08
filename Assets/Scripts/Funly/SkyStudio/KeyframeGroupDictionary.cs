namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class KeyframeGroupDictionary : global::UnityEngine.ISerializationCallbackReceiver, global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable
	{
		[global::System.NonSerialized]
		private global::System.Collections.Generic.Dictionary<string, global::Funly.SkyStudio.IKeyframeGroup> m_Groups;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.ColorGroupDictionary m_ColorGroup;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.NumberGroupDictionary m_NumberGroup;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.TextureGroupDictionary m_TextureGroup;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.SpherePointGroupDictionary m_SpherePointGroup;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.BoolGroupDictionary m_BoolGroup;

		public global::Funly.SkyStudio.IKeyframeGroup this[string aKey]
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

		public global::System.Collections.Generic.IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
