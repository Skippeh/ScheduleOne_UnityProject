namespace ScheduleOne.Equipping.Framework
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Equippable (Custom Handler)", menuName = "ScheduleOne/Equipping/Equippable (Custom Handler)")]
	public class CustomHandlerEquippableData : global::ScheduleOne.Core.Equipping.Framework.EquippableData
	{
		[global::UnityEngine.Header("Custom Handler")]
		[global::UnityEngine.Tooltip("If not assigned, the handler will be looked up in the EquippableHandlerService as normal.")]
		public global::ScheduleOne.Equipping.EquippedItemHandler Handler;

		private void OnValidate()
		{
		}
	}
}
