namespace ScheduleOne.ObjectScripts
{
	public class MixingStationMk2 : global::ScheduleOne.ObjectScripts.MixingStation
	{
		public global::UnityEngine.Animation Animation;

		[global::UnityEngine.Header("Screen")]
		public global::UnityEngine.Canvas ScreenCanvas;

		public global::UnityEngine.UI.Image OutputIcon;

		public global::UnityEngine.RectTransform QuestionMark;

		public global::TMPro.TextMeshProUGUI QuantityLabel;

		public global::TMPro.TextMeshProUGUI ProgressLabel;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EMixingStationMk2Assembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EMixingStationMk2Assembly_002DCSharp_002Edll_Excuted;

		protected override void OnTimePass(int minutes)
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

		protected override void SetMixerToLowered()
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
