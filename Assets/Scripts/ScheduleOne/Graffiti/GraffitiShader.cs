namespace ScheduleOne.Graffiti
{
	public class GraffitiShader
	{
		public struct StrokeData
		{
			public global::Unity.Mathematics.uint2 Start;

			public global::Unity.Mathematics.uint2 End;

			public uint Color;

			public uint Size;

			public static int Stride => 0;
		}

		private int _kernal;

		private global::UnityEngine.ComputeShader _shader;

		private global::UnityEngine.Texture2D _texture;

		private int _width;

		private int _height;

		private global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.GraffitiShader.StrokeData> _strokes;

		private float[] _falloffTable;

		public void Initialise(global::UnityEngine.Texture2D texture, int minStrokeSize, int maxStrokeSize, global::UnityEngine.AnimationCurve falloffCurve)
		{
		}

		public void Draw()
		{
		}

		public void ClearStrokes()
		{
		}

		public void AddStrokes(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes)
		{
		}

		public void RemoveStrokes(int count)
		{
		}

		private void CreateFalloffTables(int minFalloff, int maxFalloff, global::UnityEngine.AnimationCurve falloffCurve)
		{
		}
	}
}
