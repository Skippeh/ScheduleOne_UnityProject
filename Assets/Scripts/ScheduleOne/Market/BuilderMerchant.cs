using ScheduleOne.Interaction;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Market
{
	public class BuilderMerchant : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		protected int openTime;

		[SerializeField]
		protected int closeTime;

		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		[SerializeField]
		private PropertySelector selector;

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private void PropertySelected(ScheduleOne.Property.Property p)
		{
		}
	}
}
