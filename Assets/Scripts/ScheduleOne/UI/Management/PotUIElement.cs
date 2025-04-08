namespace ScheduleOne.UI.Management
{
	public class PotUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image SeedIcon;

		public global::UnityEngine.GameObject NoSeed;

		public global::UnityEngine.UI.Image Additive1Icon;

		public global::UnityEngine.UI.Image Additive2Icon;

		public global::UnityEngine.UI.Image Additive3Icon;

		public global::ScheduleOne.ObjectScripts.Pot AssignedPot { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.Pot pot)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
