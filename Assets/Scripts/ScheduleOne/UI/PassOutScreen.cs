using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class PassOutScreen : Singleton<PassOutScreen>
	{
		public const float CASH_LOSS_MIN = 50f;

		public const float CASH_LOSS_MAX = 500f;

		[Header("References")]
		public Canvas Canvas;

		public CanvasGroup Group;

		public Transform RecoveryPointsContainer;

		public TextMeshProUGUI MainLabel;

		public TextMeshProUGUI ContextLabel;

		public Animation Anim;

		private float cashLoss;

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
