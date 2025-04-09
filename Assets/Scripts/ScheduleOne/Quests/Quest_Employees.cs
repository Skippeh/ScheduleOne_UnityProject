using System.Collections.Generic;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	public abstract class Quest_Employees : Quest
	{
		public EEmployeeType EmployeeType;

		public QuestEntry AssignBedEntry;

		public QuestEntry PayEntry;

		public abstract List<Employee> GetEmployees();

		protected override void MinPass()
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
