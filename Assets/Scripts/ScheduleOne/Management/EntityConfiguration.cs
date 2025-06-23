namespace ScheduleOne.Management
{
	public class EntityConfiguration
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Management.ConfigField> Fields;

		public global::UnityEngine.Events.UnityEvent onChanged;

		public global::ScheduleOne.Management.ConfigurationReplicator Replicator { get; protected set; }

		public global::ScheduleOne.Management.IConfigurable Configurable { get; protected set; }

		public bool IsSelected { get; protected set; }

		public EntityConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable)
		{
		}

		protected void InvokeChanged()
		{
		}

		public void ReplicateField(global::ScheduleOne.Management.ConfigField field, global::FishNet.Connection.NetworkConnection conn = null)
		{
		}

		public void ReplicateAllFields(global::FishNet.Connection.NetworkConnection conn = null, bool replicateDefaults = true)
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void Selected()
		{
		}

		public virtual void Deselected()
		{
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		public virtual string GetSaveString()
		{
			return null;
		}
	}
}
