using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class PotUIElement : WorldspaceUIElement
	{
		[Header("References")]
		public Image SeedIcon;

		public GameObject NoSeed;

		public Image Additive1Icon;

		public Image Additive2Icon;

		public Image Additive3Icon;

		public Pot AssignedPot { get; protected set; }

		public void Initialize(Pot pot)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
