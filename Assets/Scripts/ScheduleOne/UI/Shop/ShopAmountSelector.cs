namespace ScheduleOne.UI.Shop
{
	public class ShopAmountSelector : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		public global::TMPro.TMP_InputField InputField;

		public global::UnityEngine.Events.UnityEvent<int> onSubmitted;

		public bool IsOpen { get; private set; }

		public int SelectedAmount { get; private set; }

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void OnSubmitted(string value)
		{
		}

		private void OnValueChanged(string value)
		{
		}
	}
}
