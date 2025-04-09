using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	public class Eyebrow : MonoBehaviour
	{
		public enum ESide
		{
			Right = 0,
			Left = 1
		}

		private const float eyebrowHeightMultiplier = 0.01f;

		[SerializeField]
		private Vector3 EyebrowDefaultScale;

		[SerializeField]
		private Vector3 EyebrowDefaultLocalPos;

		[SerializeField]
		protected ESide Side;

		[SerializeField]
		protected Transform Model;

		[SerializeField]
		protected MeshRenderer Rend;

		[Header("Eyebrow Data - Readonly")]
		[SerializeField]
		private Color col;

		[SerializeField]
		private float scale;

		[SerializeField]
		private float thickness;

		[SerializeField]
		private float restingAngle;

		public void SetScale(float _scale)
		{
		}

		public void SetThickness(float thickness)
		{
		}

		public void SetRestingAngle(float _angle)
		{
		}

		public void SetRestingHeight(float normalizedHeight)
		{
		}

		public void SetColor(Color _col)
		{
		}
	}
}
