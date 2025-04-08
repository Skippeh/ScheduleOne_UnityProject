namespace ScheduleOne.Tiles
{
	public class TileAppearance : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer tileMesh;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material mat_White;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material mat_Blue;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material mat_Red;

		public void Awake()
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetColor(global::ScheduleOne.Tiles.ETileColor col)
		{
		}
	}
}
