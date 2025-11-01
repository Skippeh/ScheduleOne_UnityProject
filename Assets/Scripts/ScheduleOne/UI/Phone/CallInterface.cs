namespace ScheduleOne.UI.Phone
{
	public class CallInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Phone.CallInterface>
	{
		public const float TIME_PER_CHAR = 0.015f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.Image ProfilePicture;

		public global::TMPro.TextMeshProUGUI NameLabel;

		public global::TMPro.TextMeshProUGUI MainText;

		public global::UnityEngine.RectTransform ContinuePrompt;

		public global::UnityEngine.Animation OpenAnim;

		public global::ScheduleOne.Audio.AudioSourceController TypewriterEffectSound;

		public global::UnityEngine.CanvasGroup CanvasGroup;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Color Highlight1Color;

		private int currentCallStage;

		private global::UnityEngine.Coroutine slideRoutine;

		private bool skipRollout;

		private global::UnityEngine.Coroutine rolloutRoutine;

		private string highlight1Hex;

		public global::System.Action<global::ScheduleOne.ScriptableObjects.PhoneCallData> CallCompleted;

		public global::System.Action<global::ScheduleOne.ScriptableObjects.PhoneCallData> CallStarted;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData ActiveCallData { get; private set; }

		public bool IsOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public void StartCall(global::ScheduleOne.ScriptableObjects.PhoneCallData data, global::ScheduleOne.ScriptableObjects.CallerID caller, int startStage = 0)
		{
		}

		public void EndCall()
		{
		}

		private void Close()
		{
		}

		public void Continue()
		{
		}

		private void ShowStage(int stageIndex, float initialDelay = 0f)
		{
		}

		private string ProcessText(string text)
		{
			return null;
		}

		private string GetVisibleText(int charactersShown, string fullText)
		{
			return null;
		}

		private void SetIsVisible(bool visible)
		{
		}
	}
}
