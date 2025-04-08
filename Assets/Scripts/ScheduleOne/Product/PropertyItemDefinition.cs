namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "PropertyItemDefinition", menuName = "ScriptableObjects/PropertyItemDefinition", order = 1)]
	public class PropertyItemDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[global::UnityEngine.Header("Properties")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Properties.Property> Properties;

		public virtual void Initialize(global::System.Collections.Generic.List<global::ScheduleOne.Properties.Property> properties)
		{
		}

		public bool HasProperty(global::ScheduleOne.Properties.Property property)
		{
			return false;
		}
	}
}
