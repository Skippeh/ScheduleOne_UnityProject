namespace ScheduleOne.Persistence.Loaders
{
	public class EmployeeLoader : global::ScheduleOne.Persistence.Loaders.NPCLoader
	{
		public override string NPCType => null;

		public override void Load(global::ScheduleOne.Persistence.Datas.DynamicSaveData saveData)
		{
		}

		protected virtual global::ScheduleOne.Employees.Employee CreateAndLoadEmployee(global::ScheduleOne.Persistence.Datas.DynamicSaveData saveData)
		{
			return null;
		}
	}
}
