namespace ScheduleOne.UI.Management
{
	public class MushroomBedUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image SpawnIcon;

		public global::UnityEngine.GameObject NoSpawn;

		public global::UnityEngine.UI.Image Additive1Icon;

		public global::UnityEngine.UI.Image Additive2Icon;

		public global::UnityEngine.UI.Image Additive3Icon;

		public global::ScheduleOne.ObjectScripts.MushroomBed AssignedMustroomBed { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.MushroomBed bed)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
