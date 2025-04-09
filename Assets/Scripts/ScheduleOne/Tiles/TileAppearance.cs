using UnityEngine;

namespace ScheduleOne.Tiles
{
	public class TileAppearance : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		protected MeshRenderer tileMesh;

		[Header("Settings")]
		[SerializeField]
		protected Material mat_White;

		[SerializeField]
		protected Material mat_Blue;

		[SerializeField]
		protected Material mat_Red;

		public void Awake()
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetColor(ETileColor col)
		{
		}
	}
}
