using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		[Header("References")]
		public Button Button1;

		public Button Button2;

		protected override void Awake()
		{
		}

		public override void ApplyValue()
		{
		}

		public void OnButton1()
		{
		}

		public void OnButton2()
		{
		}
	}
}
