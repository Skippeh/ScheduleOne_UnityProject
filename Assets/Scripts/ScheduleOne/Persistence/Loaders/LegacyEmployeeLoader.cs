namespace ScheduleOne.Persistence.Loaders
{
	public class LegacyEmployeeLoader : global::ScheduleOne.Persistence.Loaders.LegacyNPCLoader
	{
		public override string NPCType => null;

		public global::ScheduleOne.Employees.Employee LoadAndCreateEmployee(string mainPath)
		{
			return null;
		}
	}
}
