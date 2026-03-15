namespace ScheduleOne
{
	public class UIHorizontalSelector : global::ScheduleOne.UIOption
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button prevButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button nextButton;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI currentOptionNameText;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.UIOption.OptionInfo> OnChanged;

		private global::System.Collections.Generic.List<global::ScheduleOne.UIOption.OptionInfo> options;

		private int currentIndex;

		protected override float NavigationRepeatRateMult => 0f;

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

		private void MovePrev()
		{
		}

		private void MoveNext()
		{
		}

		private void UpdateCurrentOptionText()
		{
		}

		public void SetOptions(global::System.Collections.Generic.List<global::ScheduleOne.UIOption.OptionInfo> newOptions, int defaultIndex = 0)
		{
		}
	}
}
