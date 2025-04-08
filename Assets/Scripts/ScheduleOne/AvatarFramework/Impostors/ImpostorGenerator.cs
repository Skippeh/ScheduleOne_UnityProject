namespace ScheduleOne.AvatarFramework.Impostors
{
	public class ImpostorGenerator : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Camera ImpostorCamera;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		[global::UnityEngine.Header("Settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.AvatarSettings> GenerationQueue;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D output;
	}
}
