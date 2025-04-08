namespace ScheduleOne.Variables
{
	public class NumberVariable : global::ScheduleOne.Variables.Variable<float>
	{
		public NumberVariable(string name, global::ScheduleOne.Variables.EVariableReplicationMode replicationMode, bool persistent, global::ScheduleOne.Variables.EVariableMode mode, global::ScheduleOne.PlayerScripts.Player owner, float value)
			: base((string)null, default(global::ScheduleOne.Variables.EVariableReplicationMode), persistent: false, default(global::ScheduleOne.Variables.EVariableMode), (global::ScheduleOne.PlayerScripts.Player)null, (float)default)
		{
		}//IL_0024: Expected F4, but got O


		public override bool TryDeserialize(string valueString, out float value)
		{
			value = default(float);
			return false;
		}

		public override bool EvaluateCondition(global::ScheduleOne.Variables.Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
