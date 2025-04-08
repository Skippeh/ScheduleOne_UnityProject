namespace VLB_Samples
{
	public class LightGenerator : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Range(1f, 100f)]
		[global::UnityEngine.SerializeField]
		private int CountX;

		[global::UnityEngine.Range(1f, 100f)]
		[global::UnityEngine.SerializeField]
		private int CountY;

		[global::UnityEngine.SerializeField]
		private float OffsetUnits;

		[global::UnityEngine.SerializeField]
		private float PositionY;

		[global::UnityEngine.SerializeField]
		private bool NoiseEnabled;

		[global::UnityEngine.SerializeField]
		private bool AddLight;

		public void Generate()
		{
		}
	}
}
