using System.Collections.Generic;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	public class Quest_Packagers : Quest_Employees
	{
		public QuestEntry AssignWorkEntry;

		protected override void MinPass()
		{
		}

		public override List<Employee> GetEmployees()
		{
			return null;
		}
	}
}
