namespace ScheduleOne.FX
{
	[global::UnityEngine.CreateAssetMenu(fileName = "PsychedelicFullScreenData", menuName = "ScriptableObjects/FX/Psychedelic FullScreen Data", order = 1)]
	public class PsychedelicFullScreenData : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.Header("Properties")]
		public float NoiseScale;

		public float Blend;

		public global::UnityEngine.Vector2 PanSpeed;

		public bool DoesBounce;

		public float Amplitude;

		public global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties ConvertToMaterialProperties()
		{
			return null;
		}
	}
}
