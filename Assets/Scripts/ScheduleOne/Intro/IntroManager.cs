namespace ScheduleOne.Intro
{
	public class IntroManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Intro.IntroManager>
	{
		public const float SKIP_TIME = 0.5f;

		public int CurrentStep;

		[global::UnityEngine.Header("Settings")]
		public int TimeOfDayOverride;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.Transform PlayerInitialPosition;

		public global::UnityEngine.Transform PlayerInitialPosition_AfterRVExplosion;

		public global::UnityEngine.Transform CameraContainer;

		public global::UnityEngine.Animation Anim;

		public global::UnityEngine.GameObject SkipContainer;

		public global::UnityEngine.UI.Image SkipDial;

		public global::UnityEngine.GameObject[] DisableDuringIntro;

		public global::ScheduleOne.Property.RV rv;

		public global::UnityEngine.Events.UnityEvent onIntroDone;

		public global::UnityEngine.Events.UnityEvent onIntroDoneAsServer;

		public string MusicName;

		private float currentSkipTime;

		private bool depressed;

		public bool IsPlaying { get; protected set; }

		protected override void Awake()
		{
		}

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

		public void CharacterCreationDone(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings avatar, global::System.Collections.Generic.List<global::ScheduleOne.Clothing.ClothingInstance> clothes)
		{
		}

		public void PassedStep(int stepIndex)
		{
		}
	}
}
