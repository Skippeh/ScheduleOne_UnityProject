namespace ScheduleOne.ObjectScripts.Cash
{
	public class CashStackVisuals : global::UnityEngine.MonoBehaviour
	{
		public const float MAX_AMOUNT = 1000f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Visuals_Under100;

		public global::UnityEngine.GameObject[] Notes;

		public global::UnityEngine.GameObject Visuals_Over100;

		public global::UnityEngine.GameObject[] Bills;

		private void Awake()
		{
		}

		public void ShowAmount(float amount)
		{
		}
	}
}
