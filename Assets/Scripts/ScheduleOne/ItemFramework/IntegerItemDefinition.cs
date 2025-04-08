namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "IntegerItemDefinition", menuName = "ScriptableObjects/IntegerItemDefinition", order = 1)]
	public class IntegerItemDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public int DefaultValue;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
