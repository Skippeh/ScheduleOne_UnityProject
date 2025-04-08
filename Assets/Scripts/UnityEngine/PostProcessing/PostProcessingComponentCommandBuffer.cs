namespace UnityEngine.PostProcessing
{
	public abstract class PostProcessingComponentCommandBuffer<T> : global::UnityEngine.PostProcessing.PostProcessingComponent<T> where T : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public abstract global::UnityEngine.Rendering.CameraEvent GetCameraEvent();

		public abstract string GetName();

		public abstract void PopulateCommandBuffer(global::UnityEngine.Rendering.CommandBuffer cb);
	}
}
