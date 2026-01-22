namespace ScheduleOne.Graffiti
{
	public class PixelData
	{
		public global::ScheduleOne.Graffiti.UShort2 Coordinate;

		public global::ScheduleOne.Graffiti.ESprayColor Color;

		public byte StrokeSize;

		public byte StrokeRadiusRoundedUp => 0;

		public byte StrokeRadiusRoundedDown => 0;

		public PixelData(global::ScheduleOne.Graffiti.UShort2 coordinate, global::ScheduleOne.Graffiti.ESprayColor color, byte strokeSize)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public float GetPixelStrength(int pixelIndex)
		{
			return 0f;
		}
	}
}
