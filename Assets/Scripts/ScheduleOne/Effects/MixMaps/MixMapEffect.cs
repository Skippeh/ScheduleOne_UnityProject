namespace ScheduleOne.Effects.MixMaps
{
	public class MixMapEffect : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Effects.Effect Property;

		[global::UnityEngine.Range(0.05f, 3f)]
		public float Radius;

		public global::UnityEngine.Vector2 Position => default(global::UnityEngine.Vector2);

		public void OnValidate()
		{
		}
	}
}
