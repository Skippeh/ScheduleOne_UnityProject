using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class DeathScreen : Singleton<DeathScreen>
	{
		[Header("References")]
		public Canvas canvas;

		public RectTransform Container;

		public CanvasGroup group;

		public Button respawnButton;

		public Button loadSaveButton;

		public Animation Anim;

		public AudioSourceController Sound;

		private bool arrested;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void RespawnClicked()
		{
		}

		private void LoadSaveClicked()
		{
		}

		public void Open()
		{
		}

		private bool CanRespawn()
		{
			return false;
		}

		public void Close()
		{
		}
	}
}
