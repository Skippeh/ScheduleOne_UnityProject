namespace ScheduleOne.Casino
{
	public class CasinoGameInteraction : global::UnityEngine.MonoBehaviour
	{
		public string GameName;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Casino.CasinoGamePlayers Players;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::System.Action<global::ScheduleOne.PlayerScripts.Player> onLocalPlayerRequestJoin;

		private void Awake()
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}
	}
}
