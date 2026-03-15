namespace ScheduleOne
{
	public class UISlider : global::ScheduleOne.UIOption
	{
		[global::UnityEngine.SerializeField]
		private bool canUpdateValueText;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Slider slider;

		[global::UnityEngine.SerializeField]
		private float stepSize;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI valueText;

		public global::UnityEngine.Events.UnityEvent<float> OnChanged;

		protected override void Awake()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void MoveLeft()
		{
		}

		protected override void MoveRight()
		{
		}

		private void UpdateSliderChanged()
		{
		}

		private void UpdateText()
		{
		}
	}
}
