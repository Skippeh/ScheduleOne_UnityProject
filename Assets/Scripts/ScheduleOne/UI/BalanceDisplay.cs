namespace ScheduleOne.UI
{
	public class BalanceDisplay : global::UnityEngine.MonoBehaviour
	{
		public const float RESIDUAL_TIME = 3f;

		public const float FADE_TIME = 0.25f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.CanvasGroup Group;

		public global::TMPro.TextMeshProUGUI BalanceLabel;

		public bool active { get; protected set; }

		public float timeSinceActiveSet { get; protected set; }

		protected virtual void Update()
		{
		}

		public void SetBalance(float balance)
		{
		}

		public void Show()
		{
		}
	}
}
