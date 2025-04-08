namespace ScheduleOne.Properties.MixMaps
{
	public class Effect : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Properties.Property Property;

		[global::UnityEngine.Range(0.05f, 3f)]
		public float Radius;

		public global::UnityEngine.Vector2 Position => default(global::UnityEngine.Vector2);

		public void OnValidate()
		{
		}
	}
}
