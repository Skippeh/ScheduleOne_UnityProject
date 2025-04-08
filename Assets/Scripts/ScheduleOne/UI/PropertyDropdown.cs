namespace ScheduleOne.UI
{
	public class PropertyDropdown : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Property.Property selectedProperty;

		private global::TMPro.TMP_Dropdown TMP_dropdown;

		private global::UnityEngine.UI.Dropdown dropdown;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.Property.Property> intToProperty;

		public global::System.Action onSelectionChanged;

		protected virtual void Awake()
		{
		}

		private void PropertyAcquired(global::ScheduleOne.Property.Property p)
		{
		}

		private void ValueChanged(int newVal)
		{
		}
	}
}
