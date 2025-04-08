namespace ScheduleOne.UI.CharacterCreator
{
	public class BaseCharacterCreatorField : global::UnityEngine.MonoBehaviour
	{
		public string PropertyName;

		public global::ScheduleOne.AvatarFramework.Customization.CharacterCreator.ECategory Category;

		private global::ScheduleOne.AvatarFramework.Customization.CharacterCreator Creator;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void ApplyValue()
		{
		}

		public virtual void WriteValue(bool applyValue = true)
		{
		}
	}
}
