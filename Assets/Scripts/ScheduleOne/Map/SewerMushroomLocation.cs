namespace ScheduleOne.Map
{
	public class SewerMushroomLocation : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public struct MushroomLocationData
		{
			public bool isActive;

			public global::UnityEngine.Vector3 location;

			public global::UnityEngine.Quaternion rotation;

			public float scale;
		}

		[global::UnityEngine.Header("Properties")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Map.SewerMushroomLocation.MushroomLocationData> _data;

		public void SetMushroomsFromData(global::UnityEngine.GameObject mushroomObject)
		{
		}

		private void SetMushroomFromData(global::UnityEngine.Transform childMushroomObj, global::ScheduleOne.Map.SewerMushroomLocation.MushroomLocationData data)
		{
		}

		public void ClearData()
		{
		}

		[global::EasyButtons.Button]
		public void SetMushroomLocationData()
		{
		}
	}
}
