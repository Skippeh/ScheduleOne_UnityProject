namespace ScheduleOne.ObjectScripts.WateringCan
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "TrashGrabberDefinition", menuName = "ScriptableObjects/Item Definitions/TrashGrabberDefinition", order = 1)]
	public class TrashGrabberDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
