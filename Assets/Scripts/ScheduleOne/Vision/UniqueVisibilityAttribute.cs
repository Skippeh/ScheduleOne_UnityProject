namespace ScheduleOne.Vision
{
	[global::System.Serializable]
	public class UniqueVisibilityAttribute : global::ScheduleOne.Vision.VisibilityAttribute
	{
		public string uniquenessCode;

		public UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1)
			: base(null, 0f, 0f, 0)
		{
		}
	}
}
