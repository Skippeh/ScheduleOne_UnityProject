namespace ScheduleOne.AvatarFramework
{
	public class MugshotGenerator : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.AvatarFramework.MugshotGenerator>
	{
		public string OutputPath;

		public global::ScheduleOne.AvatarFramework.AvatarSettings Settings;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.AvatarFramework.Avatar MugshotRig;

		public global::ScheduleOne.DevUtilities.IconGenerator Generator;

		public global::ScheduleOne.AvatarFramework.AvatarSettings DefaultSettings;

		public global::UnityEngine.Transform LookAtPosition;

		private global::UnityEngine.Texture2D finalTexture;

		private bool generate;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void FinalizeMugshot()
		{
		}

		[global::EasyButtons.Button]
		public void GenerateMugshot()
		{
		}

		public void GenerateMugshot(global::ScheduleOne.AvatarFramework.AvatarSettings settings, bool fileToFile, global::System.Action<global::UnityEngine.Texture2D> callback)
		{
		}
	}
}
