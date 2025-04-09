using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	public class MixingStationMk2 : MixingStation
	{
		public Animation Animation;

		[Header("Screen")]
		public Canvas ScreenCanvas;

		public Image OutputIcon;

		public RectTransform QuestionMark;

		public TextMeshProUGUI QuantityLabel;

		public TextMeshProUGUI ProgressLabel;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EMixingStationMk2Assembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EMixingStationMk2Assembly_002DCSharp_002Edll_Excuted;

		protected override void MinPass()
		{
		}

		public override void MixingStart()
		{
		}

		public override void MixingDone()
		{
		}

		private void EnableScreen()
		{
		}

		private void UpdateScreen()
		{
		}

		private void DisableScreen()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
