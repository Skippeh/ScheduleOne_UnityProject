namespace ScheduleOne.Equipping.Framework
{
	public abstract class GenericEquippableItemDefinition<T> : global::ScheduleOne.ItemFramework.StorableItemDefinition where T : global::ScheduleOne.Core.Equipping.Framework.EquippableData
	{
		public new T EquippableData { get; private set; }

		public override void ValidateDefinition()
		{
		}
	}
}
