namespace ScheduleOne.Variables
{
	public class BoolVariable : global::ScheduleOne.Variables.Variable<bool>
	{
		public BoolVariable(string name, global::ScheduleOne.Variables.EVariableReplicationMode replicationMode, bool persistent, global::ScheduleOne.Variables.EVariableMode mode, global::ScheduleOne.PlayerScripts.Player owner, bool value)
			: base((string)null, default(global::ScheduleOne.Variables.EVariableReplicationMode), persistent: false, default(global::ScheduleOne.Variables.EVariableMode), (global::ScheduleOne.PlayerScripts.Player)null, (byte)(int)default != 0)
		{
		}//IL_0024: Expected I4, but got O


		public override bool TryDeserialize(string valueString, out bool value)
		{
			value = default(bool);
			return false;
		}

		public override bool EvaluateCondition(global::ScheduleOne.Variables.Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
