using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	public class NumberVariable : Variable<float>
	{
		public NumberVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value)
			: base(name, replicationMode, persistent, mode, owner, value)
		{
		}

		public override bool TryDeserialize(string valueString, out float value)
		{
			value = default(float);
			return false;
		}

		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
