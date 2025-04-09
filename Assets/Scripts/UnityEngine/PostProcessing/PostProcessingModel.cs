using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public abstract class PostProcessingModel
	{
		[SerializeField]
		[GetSet("enabled")]
		private bool m_Enabled;

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public abstract void Reset();

		public virtual void OnValidate()
		{
		}
	}
}
