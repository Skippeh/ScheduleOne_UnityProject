namespace ScheduleOne.UI.Phone
{
	public class CustomerSelector : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.GameObject ButtonPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform EntriesContainer;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Economy.Customer> onCustomerSelected;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> customerEntries;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.RectTransform, global::ScheduleOne.Economy.Customer> entryToCustomer;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void CreateEntry(global::ScheduleOne.Economy.Customer customer)
		{
		}

		private void CustomerSelected(global::ScheduleOne.Economy.Customer customer)
		{
		}
	}
}
