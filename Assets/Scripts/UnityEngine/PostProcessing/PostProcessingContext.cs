namespace UnityEngine.PostProcessing
{
	public class PostProcessingContext
	{
		public PostProcessingProfile profile;

		public Camera camera;

		public MaterialFactory materialFactory;

		public RenderTextureFactory renderTextureFactory;

		public bool interrupted { get; private set; }

		public bool isGBufferAvailable => false;

		public bool isHdr => false;

		public int width => 0;

		public int height => 0;

		public Rect viewport => default(Rect);

		public void Interrupt()
		{
		}

		public PostProcessingContext Reset()
		{
			return null;
		}
	}
}
