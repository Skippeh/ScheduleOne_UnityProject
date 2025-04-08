namespace UnityEngine.PostProcessing
{
	public abstract class PostProcessingComponent<T> : global::UnityEngine.PostProcessing.PostProcessingComponentBase where T : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public T model { get; internal set; }

		public virtual void Init(global::UnityEngine.PostProcessing.PostProcessingContext pcontext, T pmodel)
		{
		}

		public override global::UnityEngine.PostProcessing.PostProcessingModel GetModel()
		{
			return null;
		}
	}
}
