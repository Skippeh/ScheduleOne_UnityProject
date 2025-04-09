using System.Collections.Generic;
using FishNet.Connection;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class EntityConfiguration
	{
		public List<ConfigField> Fields;

		public UnityEvent onChanged;

		public ConfigurationReplicator Replicator { get; protected set; }

		public IConfigurable Configurable { get; protected set; }

		public bool IsSelected { get; protected set; }

		public EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable)
		{
		}

		protected void InvokeChanged()
		{
		}

		public void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
		}

		public void ReplicateAllFields(NetworkConnection conn = null, bool replicateDefaults = true)
		{
		}

		public virtual void Destroy()
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
