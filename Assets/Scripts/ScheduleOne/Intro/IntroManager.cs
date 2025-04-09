using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Intro
{
	public class IntroManager : Singleton<IntroManager>
	{
		public const float SKIP_TIME = 0.5f;

		public int CurrentStep;

		[Header("Settings")]
		public int TimeOfDayOverride;

		[Header("References")]
		public GameObject Container;

		public Transform PlayerInitialPosition;

		public Transform PlayerInitialPosition_AfterRVExplosion;

		public Transform CameraContainer;

		public Animation Anim;

		public GameObject SkipContainer;

		public Image SkipDial;

		public GameObject[] DisableDuringIntro;

		public RV rv;

		public UnityEvent onIntroDone;

		public UnityEvent onIntroDoneAsServer;

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

		[Button]
		public void Play()
		{
		}

		private void PlayMusic()
		{
		}

		public void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
		}

		public void PassedStep(int stepIndex)
		{
		}
	}
}
