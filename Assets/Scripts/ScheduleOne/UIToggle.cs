namespace ScheduleOne
{
	public class UIToggle : global::ScheduleOne.UIOption
	{
		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI buttonText;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Image toggleImage;

		private const string ONTEXT = "On";

		private const string OFFTEXT = "Off";

		public global::UnityEngine.Events.UnityEvent<bool> OnChanged;

		private bool state;

		protected override void Awake()
		{
		}

		protected override void OnUpdate()
		{
		}

		public void SetState(bool state)
		{
		}

		public void SetStateWithoutNotify(bool state)
		{
		}

		private void SetStateInternal(bool state)
		{
		}

		private void SetButtonState(bool state)
		{
		}
	}
}
