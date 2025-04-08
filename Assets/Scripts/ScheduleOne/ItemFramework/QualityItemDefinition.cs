namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/QualityItemDefinition", order = 1)]
	public class QualityItemDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[global::UnityEngine.Header("Quality")]
		public global::ScheduleOne.ItemFramework.EQuality DefaultQuality;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
