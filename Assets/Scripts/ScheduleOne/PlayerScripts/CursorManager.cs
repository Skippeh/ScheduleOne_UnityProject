namespace ScheduleOne.PlayerScripts
{
	public class CursorManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.PlayerScripts.CursorManager>
	{
		public enum ECursorType
		{
			Default = 0,
			Finger = 1,
			OpenHand = 2,
			Grab = 3,
			Scissors = 4,
			Spray = 5
		}

		[global::System.Serializable]
		public class CursorConfig
		{
			public global::ScheduleOne.PlayerScripts.CursorManager.ECursorType CursorType;

			public global::UnityEngine.Texture2D Texture;

			public global::UnityEngine.Vector2 HotSpot;
		}

		[global::UnityEngine.Header("References")]
		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.CursorManager.CursorConfig> Cursors;

		protected override void Awake()
		{
		}

		public void SetCursorAppearance(global::ScheduleOne.PlayerScripts.CursorManager.ECursorType type)
		{
		}
	}
}
