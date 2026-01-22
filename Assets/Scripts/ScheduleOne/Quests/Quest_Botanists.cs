namespace ScheduleOne.Quests
{
	public class Quest_Botanists : global::ScheduleOne.Quests.Quest_Employees
	{
		public global::ScheduleOne.Quests.QuestEntry AssignSuppliesEntry;

		public global::ScheduleOne.Quests.QuestEntry AssignWorkEntry;

		public global::ScheduleOne.Quests.QuestEntry AssignDestinationEntry;

		protected override void OnMinPass()
		{
		}

		public override global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee> GetEmployees()
		{
			return null;
		}
	}
}
