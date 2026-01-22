namespace ScheduleOne.Quests
{
	public abstract class Quest_Employees : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Employees.EEmployeeType EmployeeType;

		public global::ScheduleOne.Quests.QuestEntry AssignBedEntry;

		public global::ScheduleOne.Quests.QuestEntry PayEntry;

		public abstract global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee> GetEmployees();

		protected override void OnMinPass()
		{
		}

		protected bool AreAnyEmployeesAssignedBeds()
		{
			return false;
		}

		protected bool AreAnyEmployeesPaid()
		{
			return false;
		}
	}
}
