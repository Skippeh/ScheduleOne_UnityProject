namespace ScheduleOne.Variables
{
	public abstract class BaseVariable
	{
		public global::ScheduleOne.Variables.EVariableReplicationMode ReplicationMode;

		public string Name;

		public bool Persistent;

		public global::ScheduleOne.Variables.EVariableMode VariableMode;

		public global::ScheduleOne.PlayerScripts.Player Owner { get; private set; }

		public BaseVariable(string name, global::ScheduleOne.Variables.EVariableReplicationMode replicationMode, bool persistent, global::ScheduleOne.Variables.EVariableMode mode, global::ScheduleOne.PlayerScripts.Player owner)
		{
		}

		public abstract object GetValue();

		public abstract void SetValue(object value, bool replicate = true);

		public abstract void ReplicateValue(global::FishNet.Connection.NetworkConnection conn);

		public virtual bool EvaluateCondition(global::ScheduleOne.Variables.Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
