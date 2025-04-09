using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Market
{
	public class Merchant : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		protected string shopName;

		[SerializeField]
		protected int openTime;

		[SerializeField]
		protected int closeTime;

		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		protected virtual void Start()
		{
		}

		public void Hovered()
		{
		}

		public virtual void Interacted()
		{
		}
	}
}
