namespace ScheduleOne
{
	public abstract class UIOption : global::UnityEngine.MonoBehaviour
	{
		public struct OptionInfo
		{
			public string OptionName;

			public int OptionIndex;
		}

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.UISelectable selectable;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI nameText;

		[global::UnityEngine.SerializeField]
		protected string optionName;

		private const float MoveThreshold = 0.25f;

		private bool wasNavPressedLastFrame;

		private float navTimer;

		protected virtual float NavigationRepeatRateMult => 0f;

		protected virtual void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void MoveLeft()
		{
		}

		protected virtual void MoveRight()
		{
		}

		protected virtual void DetectInput()
		{
		}

		protected virtual bool Navigate(global::UnityEngine.Vector2 navDir)
		{
			return false;
		}
	}
}
