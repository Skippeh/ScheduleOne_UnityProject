namespace ScheduleOne.Market
{
	public class Merchant : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected string shopName;

		[global::UnityEngine.SerializeField]
		protected int openTime;

		[global::UnityEngine.SerializeField]
		protected int closeTime;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

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
