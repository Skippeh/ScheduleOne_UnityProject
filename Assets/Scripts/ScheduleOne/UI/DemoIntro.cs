using EasyButtons;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class DemoIntro : Singleton<DemoIntro>
	{
		public const float SKIP_TIME = 0.5f;

		public Animation Anim;

		public Transform PlayerInitialPosition;

		public GameObject SkipContainer;

		public Image SkipDial;

		public int SkipEvents;

		public UnityEvent onStart;

		public UnityEvent onStartAsServer;

		public UnityEvent onCutsceneDone;

		public UnityEvent onIntroDone;

		public UnityEvent onIntroDoneAsServer;

		private int CurrentStep;

		public string MusicName;

		private float currentSkipTime;

		private bool depressed;

		private bool waitingForCutsceneEnd;

		public bool IsPlaying { get; protected set; }

		private void Update()
		{
		}

		[Button]
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

		public void CharacterCreationDone(BasicAvatarSettings avatar)
		{
		}
	}
}
