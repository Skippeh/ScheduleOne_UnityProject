namespace ScheduleOne.Management
{
	public interface IConfigurable
	{
		global::ScheduleOne.Management.EntityConfiguration Configuration { get; }

		global::ScheduleOne.Management.ConfigurationReplicator ConfigReplicator { get; }

		global::ScheduleOne.Management.EConfigurableType ConfigurableType { get; }

		global::ScheduleOne.UI.Management.WorldspaceUIElement WorldspaceUI { get; set; }

		global::FishNet.Object.NetworkObject CurrentPlayerConfigurer { get; set; }

		bool IsBeingConfiguredByOtherPlayer => false;

		global::UnityEngine.Sprite TypeIcon { get; }

		global::UnityEngine.Transform Transform { get; }

		global::UnityEngine.Transform UIPoint { get; }

		bool IsDestroyed => false;

		bool CanBeSelected { get; }

		global::ScheduleOne.Property.Property ParentProperty { get; }

		global::ScheduleOne.UI.Management.WorldspaceUIElement CreateWorldspaceUI();

		void DestroyWorldspaceUI();

		void ShowOutline(global::UnityEngine.Color color);

		void HideOutline();

		void Selected()
		{
		}

		void Deselected()
		{
		}

		void SetConfigurer(global::FishNet.Object.NetworkObject player);

		void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn);
	}
}
