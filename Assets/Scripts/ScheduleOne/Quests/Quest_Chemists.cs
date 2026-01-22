namespace ScheduleOne.Quests
{
	public class Quest_Chemists : global::ScheduleOne.Quests.Quest_Employees
	{
		public global::ScheduleOne.Quests.QuestEntry AssignWorkEntry;

		protected override void OnMinPass()
		{
		}

		public override global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee> GetEmployees()
		{
			return null;
		}
	}
}
