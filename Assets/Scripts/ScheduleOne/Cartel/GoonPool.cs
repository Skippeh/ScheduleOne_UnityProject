namespace ScheduleOne.Cartel
{
	public class GoonPool : global::UnityEngine.MonoBehaviour
	{
		public const float MALE_CHANCE = 0.7f;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Cartel.CartelGoon[] goons;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Map.NPCEnterableBuilding[] exitBuildings;

		[global::UnityEngine.Header("Appearance Settings")]
		public global::ScheduleOne.AvatarFramework.AvatarSettings[] MaleBaseAppearances;

		public global::ScheduleOne.AvatarFramework.AvatarSettings[] FemaleBaseAppearances;

		public global::ScheduleOne.AvatarFramework.AvatarSettings[] MaleClothing;

		public global::ScheduleOne.AvatarFramework.AvatarSettings[] FemaleClothing;

		public global::ScheduleOne.VoiceOver.VODatabase[] MaleVoices;

		public global::ScheduleOne.VoiceOver.VODatabase[] FemaleVoices;

		public global::UnityEngine.Color[] SkinTones;

		public global::UnityEngine.Color[] HairColors;

		private global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelGoon> spawnedGoons;

		private global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelGoon> unspawnedGoons;

		public int UnspawnedGoonCount => 0;

		protected virtual void Awake()
		{
		}

		private void Update()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelGoon> SpawnMultipleGoons(global::UnityEngine.Vector3 spawnPoint, int requestedAmount, bool setAsGoonMates = true)
		{
			return null;
		}

		public global::ScheduleOne.Cartel.CartelGoonAppearance GetRandomAppearance()
		{
			return null;
		}

		public global::ScheduleOne.Cartel.CartelGoon SpawnGoon(global::UnityEngine.Vector3 spawnPoint)
		{
			return null;
		}

		public void ReturnToPool(global::ScheduleOne.Cartel.CartelGoon goon)
		{
		}

		public global::ScheduleOne.Map.NPCEnterableBuilding GetNearestExitBuilding(global::UnityEngine.Vector3 position)
		{
			return null;
		}
	}
}
