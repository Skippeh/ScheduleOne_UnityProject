namespace ScheduleOne.Graffiti
{
	public class Drawing
	{
		private ushort falloffRadius;

		private float[] falloffTable;

		private global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes;

		public global::System.Action onTextureChanged;

		public int Width { get; private set; }

		public int Height { get; private set; }

		public global::UnityEngine.Texture2D OutputTexture { get; private set; }

		public int StrokeCount => 0;

		public int PaintedPixelCount { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> GetStrokes()
		{
			return null;
		}

		public Drawing(int width, int height, ushort falloffRadius, float[] falloffTable, bool initPixels)
		{
		}

		public global::ScheduleOne.Graffiti.Drawing GetCopy()
		{
			return null;
		}

		public void DrawPaintedPixel(global::ScheduleOne.Graffiti.PixelData data, bool applyTexture)
		{
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::UnityEngine.Color LerpUnclampedFast(global::UnityEngine.Color a, global::UnityEngine.Color b, float t)
		{
			return default(global::UnityEngine.Color);
		}

		private void ApplyTexture()
		{
		}

		private bool IsCoordinateInBounds(int x, int y)
		{
			return false;
		}

		public void AddStroke(global::ScheduleOne.Graffiti.SprayStroke stroke)
		{
		}

		public void AddStrokes(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes)
		{
		}
	}
}
