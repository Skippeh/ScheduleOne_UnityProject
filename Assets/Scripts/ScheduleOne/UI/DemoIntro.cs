namespace ScheduleOne.UI
{
	public class DemoIntro : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.DemoIntro>
	{
		public const float SKIP_TIME = 0.5f;

		public global::UnityEngine.Animation Anim;

		public global::UnityEngine.Transform PlayerInitialPosition;

		public global::UnityEngine.GameObject SkipContainer;

		public global::UnityEngine.UI.Image SkipDial;

		public int SkipEvents;

		public global::UnityEngine.Events.UnityEvent onStart;

		public global::UnityEngine.Events.UnityEvent onStartAsServer;

		public global::UnityEngine.Events.UnityEvent onCutsceneDone;

		public global::UnityEngine.Events.UnityEvent onIntroDone;

		public global::UnityEngine.Events.UnityEvent onIntroDoneAsServer;

		private int CurrentStep;

		public string MusicName;

		private float currentSkipTime;

		private bool depressed;

		private bool waitingForCutsceneEnd;

		public bool IsPlaying { get; protected set; }

		private void Update()
		{
		}

		[global::EasyButtons.Button]
		public void Play()
		{
		}

		private void PlayMusic()
		{
		}

		public void ShowAvatar()
		{
		}

		public void CutsceneDone()
		{
		}

		public void PassedStep(int stepIndex)
		{
		}

		public void CharacterCreationDone(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings avatar)
		{
		}
	}
}
