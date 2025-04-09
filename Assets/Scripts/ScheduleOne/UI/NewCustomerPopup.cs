using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class NewCustomerPopup : Singleton<NewCustomerPopup>
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public CanvasGroup Group;

		public Animation Anim;

		public TextMeshProUGUI Title;

		public RectTransform[] Entries;

		public AudioSourceController SoundEffect;

		private Coroutine routine;

		public bool IsPlaying { get; protected set; }

		protected override void Awake()
		{
		}

		public void PlayPopup(Customer customer)
		{
		}

		private void DisableEntries()
		{
		}
	}
}
