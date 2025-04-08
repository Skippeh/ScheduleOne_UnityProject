namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorField<T> : global::ScheduleOne.UI.CharacterCreator.BaseCharacterCreatorField
	{
		protected global::ScheduleOne.Clothing.ClothingDefinition selectedClothingDefinition;

		public T value { get; protected set; }

		public virtual T ReadValue()
		{
			return default(T);
		}

		public override void WriteValue(bool applyValue = true)
		{
		}

		public override void ApplyValue()
		{
		}
	}
}
