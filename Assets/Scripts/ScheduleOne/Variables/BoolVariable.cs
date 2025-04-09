using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	public class BoolVariable : Variable<bool>
	{
		public BoolVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value)
			: base(name, replicationMode, persistent, mode, owner, value)
		{
		}

		public override bool TryDeserialize(string valueString, out bool value)
		{
			value = default(bool);
			return false;
		}

		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
