using FishNet.Connection;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	public abstract class BaseVariable
	{
		public EVariableReplicationMode ReplicationMode;

		public string Name;

		public bool Persistent;

		public EVariableMode VariableMode;

		public Player Owner { get; private set; }

		public BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner)
		{
		}

		public abstract object GetValue();

		public abstract void SetValue(object value, bool replicate = true);

		public abstract void ReplicateValue(NetworkConnection conn);

		public virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
