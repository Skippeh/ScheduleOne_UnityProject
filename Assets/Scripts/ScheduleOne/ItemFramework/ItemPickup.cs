namespace ScheduleOne.ItemFramework
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Interaction.InteractableObject))]
	public class ItemPickup : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.ItemFramework.ItemDefinition ItemToGive;

		public bool DestroyOnPickup;

		public bool ConditionallyActive;

		public global::ScheduleOne.Variables.Condition ActiveCondition;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Events.UnityEvent onPickup;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void Init()
		{
		}

		protected virtual void Hovered()
		{
		}

		private void Interacted()
		{
		}

		protected virtual bool CanPickup()
		{
			return false;
		}

		protected virtual void Pickup()
		{
		}

		public void Destroy()
		{
		}
	}
}
