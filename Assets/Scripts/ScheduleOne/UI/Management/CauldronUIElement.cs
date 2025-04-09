using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	public class CauldronUIElement : WorldspaceUIElement
	{
		public Cauldron AssignedCauldron { get; protected set; }

		public void Initialize(Cauldron cauldron)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
