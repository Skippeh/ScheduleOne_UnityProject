namespace ScheduleOne.Graffiti
{
	[global::System.Serializable]
	public class SprayStroke
	{
		public const int MinStrokeLength = 6;

		public const int AngleThreshold_Degrees = 10;

		public const float MaxStrokeDeviation = 5f;

		public const int ForwardSampleCount = 5;

		public const byte StrokeSize_LegacyDefault = 16;

		public const byte StrokeSize_Small = 10;

		public const byte StrokeSize_Medium = 16;

		public const byte StrokeSize_Large = 24;

		public const byte StrokeSize_ExtraLarge = 32;

		public static readonly byte[] StrokeSizePresets;

		public const byte StrokeSize_Min = 10;

		public const byte StrokeSize_Max = 32;

		public global::ScheduleOne.Graffiti.UShort2 Start;

		public global::ScheduleOne.Graffiti.UShort2 End;

		public global::ScheduleOne.Graffiti.ESprayColor Color;

		public byte StrokeSize;

		public SprayStroke(global::ScheduleOne.Graffiti.UShort2 start, global::ScheduleOne.Graffiti.UShort2 end, global::ScheduleOne.Graffiti.ESprayColor color, byte strokeSize)
		{
		}

		public global::ScheduleOne.Graffiti.SprayStroke GetCopy()
		{
			return null;
		}

		public SprayStroke()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.PixelData> GetPixelsFromStroke()
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> GetStrokesFromPixels(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.UShort2> coords, global::ScheduleOne.Graffiti.ESprayColor color, byte strokeSize, global::ScheduleOne.Graffiti.SpraySurface surface)
		{
			return null;
		}

		public void Serialize(global::System.IO.BinaryWriter writer)
		{
		}

		public static global::ScheduleOne.Graffiti.SprayStroke Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> CopyAndShiftStrokes(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes, global::ScheduleOne.Graffiti.UShort2 shift)
		{
			return null;
		}

		public static void GetBounds(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes, out global::ScheduleOne.Graffiti.UShort2 min, out global::ScheduleOne.Graffiti.UShort2 max)
		{
			min = default(global::ScheduleOne.Graffiti.UShort2);
			max = default(global::ScheduleOne.Graffiti.UShort2);
		}
	}
}
