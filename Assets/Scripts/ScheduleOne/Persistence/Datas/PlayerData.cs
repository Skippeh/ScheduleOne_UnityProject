namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PlayerData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string PlayerCode;

		public global::UnityEngine.Vector3 Position;

		public float Rotation;

		public bool IntroCompleted;

		public PlayerData(string playerCode, global::UnityEngine.Vector3 playerPos, float playerRot, bool introCompleted)
		{
		}

		public PlayerData()
		{
		}
	}
}
