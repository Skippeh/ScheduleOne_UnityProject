namespace ScheduleOne.Market
{
	public class BuilderMerchant : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected int openTime;

		[global::UnityEngine.SerializeField]
		protected int closeTime;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.PropertySelector selector;

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private void PropertySelected(global::ScheduleOne.Property.Property p)
		{
		}
	}
}
