namespace ScheduleOne.Graffiti
{
	[global::System.Serializable]
	public class SprayStroke
	{
		public const int MIN_STROKE_LENGTH = 6;

		public const int ANGLE_THRESHOLD_DEG = 10;

		public const float MAX_STROKE_DEVIATION = 5f;

		public const int FORWARD_SAMPLE_COUNT = 5;

		public global::ScheduleOne.Graffiti.UShort2 Start;

		public global::ScheduleOne.Graffiti.UShort2 End;

		public global::ScheduleOne.Graffiti.ESprayColor Color;

		public SprayStroke(global::ScheduleOne.Graffiti.UShort2 start, global::ScheduleOne.Graffiti.UShort2 end, global::ScheduleOne.Graffiti.ESprayColor color)
		{
		}

		public SprayStroke()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.PixelData> GetPixelsFromStroke()
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> GetStrokesFromPixels(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.UShort2> coords, global::ScheduleOne.Graffiti.ESprayColor color, global::ScheduleOne.Graffiti.SpraySurface surface)
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
	}
}
