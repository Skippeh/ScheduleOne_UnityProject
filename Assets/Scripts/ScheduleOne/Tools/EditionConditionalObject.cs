namespace ScheduleOne.Tools
{
	public class EditionConditionalObject : global::UnityEngine.MonoBehaviour
	{
		public enum EType
		{
			ActiveInDemo = 0,
			ActiveInFullGame = 1
		}

		public global::ScheduleOne.Tools.EditionConditionalObject.EType type;

		private void Awake()
		{
		}
	}
}
