namespace ScheduleOne.Variables
{
	public class Variable<T> : global::ScheduleOne.Variables.BaseVariable
	{
		public T Value;

		public global::UnityEngine.Events.UnityEvent<T> OnValueChanged;

		public Variable(string name, global::ScheduleOne.Variables.EVariableReplicationMode replicationMode, bool persistent, global::ScheduleOne.Variables.EVariableMode mode, global::ScheduleOne.PlayerScripts.Player owner, T value)
			: base(null, default(global::ScheduleOne.Variables.EVariableReplicationMode), persistent: false, default(global::ScheduleOne.Variables.EVariableMode), null)
		{
		}

		public override object GetValue()
		{
			return null;
		}

		public override void SetValue(object value, bool replicate)
		{
		}

		public virtual bool TryDeserialize(string valueString, out T value)
		{
			value = default(T);
			return false;
		}

		public override void ReplicateValue(global::FishNet.Connection.NetworkConnection conn)
		{
		}
	}
}
