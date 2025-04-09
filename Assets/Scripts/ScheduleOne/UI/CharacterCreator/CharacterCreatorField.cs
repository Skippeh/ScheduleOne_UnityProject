using ScheduleOne.Clothing;

namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		protected ClothingDefinition selectedClothingDefinition;

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
