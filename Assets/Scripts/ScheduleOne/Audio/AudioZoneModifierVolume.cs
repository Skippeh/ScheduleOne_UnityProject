namespace ScheduleOne.Audio
{
	public class AudioZoneModifierVolume : global::UnityEngine.MonoBehaviour, global::ScheduleOne.Audio.IAudioZoneModifier
	{
		[global::UnityEngine.Serialization.FormerlySerializedAs("Zones")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioZone> _zones;

		[global::UnityEngine.Serialization.FormerlySerializedAs("VolumeMultiplier")]
		[global::UnityEngine.SerializeField]
		private float _volumeMultiplier;

		private global::UnityEngine.BoxCollider[] _colliders;

		public float VolumeMultiplier => 0f;

		private void Start()
		{
		}

		private void Refresh()
		{
		}

		private bool IsCameraWithinVolume()
		{
			return false;
		}
	}
}
