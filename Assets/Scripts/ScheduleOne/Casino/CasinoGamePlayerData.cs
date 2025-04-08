namespace ScheduleOne.Casino
{
	public class CasinoGamePlayerData
	{
		protected global::System.Collections.Generic.Dictionary<string, bool> bools;

		protected global::System.Collections.Generic.Dictionary<string, float> floats;

		public global::ScheduleOne.Casino.CasinoGamePlayers Parent { get; private set; }

		public global::ScheduleOne.PlayerScripts.Player Player { get; private set; }

		public CasinoGamePlayerData(global::ScheduleOne.Casino.CasinoGamePlayers parent, global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public T GetData<T>(string key)
		{
			return default(T);
		}

		public void SetData<T>(string key, T value, bool network = true)
		{
		}
	}
}
