namespace ScheduleOne.Networking
{
	[global::UnityEngine.RequireComponent(typeof(global::FishNet.Managing.NetworkManager))]
	public class AutoNetworkStart : global::UnityEngine.MonoBehaviour
	{
		private enum EAutoStartType
		{
			Disabled = 0,
			Host = 1,
			Server = 2,
			Client = 3
		}

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Networking.AutoNetworkStart.EAutoStartType _autoStartType;
	}
}
