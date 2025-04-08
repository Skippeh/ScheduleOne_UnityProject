namespace ScheduleOne.ObjectScripts
{
	public class CauldronDisplayTub : global::UnityEngine.MonoBehaviour
	{
		public enum EContents
		{
			None = 0,
			CocaLeaf = 1
		}

		public global::UnityEngine.Transform CocaLeafContainer;

		public global::UnityEngine.Transform Container_Min;

		public global::UnityEngine.Transform Container_Max;

		public void Configure(global::ScheduleOne.ObjectScripts.CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
		}
	}
}
