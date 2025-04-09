using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	public class CashStackVisuals : MonoBehaviour
	{
		public const float MAX_AMOUNT = 1000f;

		[Header("References")]
		public GameObject Visuals_Under100;

		public GameObject[] Notes;

		public GameObject Visuals_Over100;

		public GameObject[] Bills;

		private void Awake()
		{
		}

		public void ShowAmount(float amount)
		{
		}
	}
}
