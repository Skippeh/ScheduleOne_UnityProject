using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	public class HandoverScreenPriceSelector : MonoBehaviour
	{
		public const float MinPrice = 1f;

		public const float MaxPrice = 9999f;

		public InputField InputField;

		public UnityEvent onPriceChanged;

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
