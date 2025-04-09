using FishNet.Connection;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Variables
{
	public class Variable<T> : BaseVariable
	{
		public T Value;

		public UnityEvent<T> OnValueChanged;

		public Variable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value)
			: base(null, default(EVariableReplicationMode), persistent: false, default(EVariableMode), null)
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

		public override void ReplicateValue(NetworkConnection conn)
		{
		}
	}
}
