namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public abstract class PostProcessingModel
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.PostProcessing.GetSet("enabled")]
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
