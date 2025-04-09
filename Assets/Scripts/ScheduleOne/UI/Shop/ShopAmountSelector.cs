using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Shop
{
	public class ShopAmountSelector : MonoBehaviour
	{
		[Header("References")]
		public RectTransform Container;

		public TMP_InputField InputField;

		public UnityEvent<int> onSubmitted;

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
