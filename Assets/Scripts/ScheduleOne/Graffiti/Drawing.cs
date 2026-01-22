namespace ScheduleOne.Graffiti
{
	public class Drawing
	{
		private class DrawData
		{
			public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.Drawing.DrawPixels> DrawPixels;

			public void Add(global::ScheduleOne.Graffiti.Drawing.DrawPixels drawPixels)
			{
			}

			public bool IsEmpty()
			{
				return false;
			}

			public void Clear()
			{
			}
		}

		private class DrawPixels
		{
			public int BottomLeftX;

			public int BottomLeftY;

			public int BlockWidth;

			public global::UnityEngine.Color[] Colors;

			public DrawPixels(int bottomLeftX, int bottomLeftY, int blockWidth, global::UnityEngine.Color[] colors)
			{
			}
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes;

		private global::UnityEngine.Texture2DArray _historyTextureArray;

		private int[] PaintedPixelHistory;

		private int[] _strokeHistory;

		private const int MAX_UNDO_STATES = 10;

		public global::System.Action onTextureChanged;

		private int _width { get; set; }

		private int _height { get; set; }

		public int TextureWidth => 0;

		public int TextureHeight => 0;

		public global::UnityEngine.Texture2D OutputTexture { get; private set; }

		public int StrokeCount => 0;

		public int PaintedPixelCount { get; set; }

		public int HistoryIndex { get; private set; }

		public int HistoryCount { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> GetStrokes()
		{
			return null;
		}

		public Drawing(int width, int height, bool initPixels)
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

		public bool CanUndo()
		{
			return false;
		}

		public void Undo()
		{
		}

		public void CacheDrawing()
		{
		}

		public void RestoreFromCache()
		{
		}

		public void AddTextureToHistory(bool saveToCache = false)
		{
		}
	}
}
