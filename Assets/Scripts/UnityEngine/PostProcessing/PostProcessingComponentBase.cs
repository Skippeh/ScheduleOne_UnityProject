namespace UnityEngine.PostProcessing
{
	public abstract class PostProcessingComponentBase
	{
		public global::UnityEngine.PostProcessing.PostProcessingContext context;

		public abstract bool active { get; }

		public virtual global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public abstract global::UnityEngine.PostProcessing.PostProcessingModel GetModel();
	}
}
