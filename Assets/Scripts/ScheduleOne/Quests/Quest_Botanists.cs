using System.Collections.Generic;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	public class Quest_Botanists : Quest_Employees
	{
		public QuestEntry AssignSuppliesEntry;

		public QuestEntry AssignWorkEntry;

		public QuestEntry AssignDestinationEntry;

		protected override void MinPass()
		{
		}

		public override List<Employee> GetEmployees()
		{
			return null;
		}
	}
}
