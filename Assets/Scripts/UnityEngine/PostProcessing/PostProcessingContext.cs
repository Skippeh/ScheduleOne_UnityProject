namespace UnityEngine.PostProcessing
{
	public class PostProcessingContext
	{
		public global::UnityEngine.PostProcessing.PostProcessingProfile profile;

		public global::UnityEngine.Camera camera;

		public global::UnityEngine.PostProcessing.MaterialFactory materialFactory;

		public global::UnityEngine.PostProcessing.RenderTextureFactory renderTextureFactory;

		public bool interrupted { get; private set; }

		public bool isGBufferAvailable => false;

		public bool isHdr => false;

		public int width => 0;

		public int height => 0;

		public global::UnityEngine.Rect viewport => default(global::UnityEngine.Rect);

		public void Interrupt()
		{
		}

		public global::UnityEngine.PostProcessing.PostProcessingContext Reset()
		{
			return null;
		}
	}
}
