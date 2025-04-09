using UnityEngine;

namespace ScheduleOne.UI.CharacterCreator
{
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		public string PropertyName;

		public ScheduleOne.AvatarFramework.Customization.CharacterCreator.ECategory Category;

		private ScheduleOne.AvatarFramework.Customization.CharacterCreator Creator;

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
