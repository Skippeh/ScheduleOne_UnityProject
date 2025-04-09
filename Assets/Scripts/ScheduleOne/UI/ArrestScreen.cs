using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class ArrestScreen : Singleton<ArrestScreen>
	{
		[Header("References")]
		public Canvas canvas;

		public CanvasGroup group;

		public AudioSourceController Sound;

		public Animation Anim;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void Continue()
		{
		}

		private void LoadSaveClicked()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
