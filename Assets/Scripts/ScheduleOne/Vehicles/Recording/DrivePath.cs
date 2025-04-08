namespace ScheduleOne.Vehicles.Recording
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "DrivePath", menuName = "ScriptableObjects/DrivePath", order = 1)]
	public class DrivePath : global::UnityEngine.ScriptableObject
	{
		public int fps;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Recording.VehicleKeyFrame> keyframes;
	}
}
