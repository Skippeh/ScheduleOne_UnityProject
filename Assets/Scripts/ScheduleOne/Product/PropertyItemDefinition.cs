namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "PropertyItemDefinition", menuName = "ScriptableObjects/PropertyItemDefinition", order = 1)]
	public class PropertyItemDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[global::UnityEngine.Header("Properties")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> Properties;

		public virtual void Initialize(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
		}

		public bool HasProperty(global::ScheduleOne.Effects.Effect property)
		{
			return false;
		}
	}
}
