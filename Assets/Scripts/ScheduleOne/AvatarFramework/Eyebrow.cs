namespace ScheduleOne.AvatarFramework
{
	public class Eyebrow : global::UnityEngine.MonoBehaviour
	{
		public enum ESide
		{
			Right = 0,
			Left = 1
		}

		private const float eyebrowHeightMultiplier = 0.01f;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 EyebrowDefaultScale;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 EyebrowDefaultLocalPos;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.AvatarFramework.Eyebrow.ESide Side;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform Model;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer Rend;

		[global::UnityEngine.Header("Eyebrow Data - Readonly")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color col;

		[global::UnityEngine.SerializeField]
		private float scale;

		[global::UnityEngine.SerializeField]
		private float thickness;

		[global::UnityEngine.SerializeField]
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

		public void SetColor(global::UnityEngine.Color _col)
		{
		}
	}
}
