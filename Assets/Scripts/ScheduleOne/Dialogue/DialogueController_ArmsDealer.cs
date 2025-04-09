using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Dialogue
{
	public class DialogueController_ArmsDealer : DialogueController
	{
		[Serializable]
		public class WeaponOption
		{
			public string Name;

			public float Price;

			public bool IsAvailable;

			public string NotAvailableReason;

			public StorableItemDefinition Item;
		}

		public List<WeaponOption> MeleeWeapons;

		public List<WeaponOption> RangedWeapons;

		public List<WeaponOption> Ammo;

		private List<WeaponOption> allWeapons;

		private WeaponOption chosenWeapon;

		private void Awake()
		{
		}

		public override void ChoiceCallback(string choiceLabel)
		{
		}

		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		private List<DialogueChoiceData> GetWeaponChoices(List<WeaponOption> options)
		{
			return null;
		}

		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}
	}
}
