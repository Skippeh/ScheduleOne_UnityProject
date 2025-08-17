namespace ScheduleOne.Graffiti
{
	public class Chunk
	{
		public global::ScheduleOne.Graffiti.UShort2 LowerLeftCorner;

		public global::ScheduleOne.Graffiti.UShort2 UpperRightCorner;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Graffiti.UShort2, global::ScheduleOne.Graffiti.PixelData> paintedPixelData;

		public Chunk(global::ScheduleOne.Graffiti.UShort2 lowerLeft, global::ScheduleOne.Graffiti.UShort2 upperRight)
		{
		}

		public void SetPixelColor(global::ScheduleOne.Graffiti.UShort2 coord, global::ScheduleOne.Graffiti.ESprayColor color)
		{
		}
	}
}
