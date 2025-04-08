namespace ScheduleOne.UI.Handover
{
	public class HandoverScreenPriceSelector : global::UnityEngine.MonoBehaviour
	{
		public const float MinPrice = 1f;

		public const float MaxPrice = 9999f;

		public global::UnityEngine.UI.InputField InputField;

		public global::UnityEngine.Events.UnityEvent onPriceChanged;

		public float Price { get; private set; }

		public void SetPrice(float price)
		{
		}

		public void RefreshPrice()
		{
		}

		public void OnPriceInputChanged(string value)
		{
		}

		public void ChangeAmount(float change)
		{
		}
	}
}
