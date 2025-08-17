namespace ScheduleOne.Graffiti
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Graffiti.SpraySurface))]
	public class SprayDisplay : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Graffiti.SpraySurface SpraySurface;

		public global::UnityEngine.Rendering.Universal.DecalProjector Projector;

		private global::UnityEngine.Material cachedMaterial;

		private void Awake()
		{
		}

		private void Redraw()
		{
		}
	}
}
