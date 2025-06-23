namespace ScheduleOne.ObjectScripts
{
	public class JukeboxInterface : global::UnityEngine.MonoBehaviour
	{
		public const float OPEN_TIME = 0.15f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ObjectScripts.Jukebox Jukebox;

		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.Transform CameraPosition;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.UI.Image PausePlayImage;

		public global::UnityEngine.UI.Button ShuffleButton;

		public global::UnityEngine.UI.Button RepeatButton;

		public global::UnityEngine.UI.Button SyncButton;

		public global::UnityEngine.RectTransform EntryContainer;

		public global::UnityEngine.GameObject AmbientDisplayContainer;

		public global::TMPro.TextMeshPro AmbientDisplaySongLabel;

		public global::TMPro.TextMeshPro AmbientDisplayTimeLabel;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Sprite PlaySprite;

		public global::UnityEngine.Sprite PauseSprite;

		public global::UnityEngine.Sprite SongEntryPlaySprite;

		public global::UnityEngine.Sprite SongEntryPauseSprite;

		public global::UnityEngine.Sprite RepeatModeSprite_None;

		public global::UnityEngine.Sprite RepeatModeSprite_Track;

		public global::UnityEngine.Sprite RepeatModeSprite_Queue;

		public global::UnityEngine.Color DeselectedColor;

		public global::UnityEngine.Color SelectedColor;

		public global::UnityEngine.GameObject SongEntryPrefab;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> songEntries;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateAmbientDisplay()
		{
		}

		private void SetupSongEntries()
		{
		}

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}

		public void PlayPausePressed()
		{
		}

		public void BackPressed()
		{
		}

		public void NextPressed()
		{
		}

		public void ShufflePressed()
		{
		}

		public void RepeatPressed()
		{
		}

		public void SyncPressed()
		{
		}

		public void SongEntryClicked(global::UnityEngine.RectTransform entry)
		{
		}

		private void RefreshSongEntries()
		{
		}

		private void RefreshUI()
		{
		}

		private void RefreshAmbientDisplay()
		{
		}
	}
}
