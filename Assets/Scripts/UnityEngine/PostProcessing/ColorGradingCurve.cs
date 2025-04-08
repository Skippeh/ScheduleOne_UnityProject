namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public sealed class ColorGradingCurve
	{
		public global::UnityEngine.AnimationCurve curve;

		[global::UnityEngine.SerializeField]
		private bool m_Loop;

		[global::UnityEngine.SerializeField]
		private float m_ZeroValue;

		[global::UnityEngine.SerializeField]
		private float m_Range;

		private global::UnityEngine.AnimationCurve m_InternalLoopingCurve;

		public ColorGradingCurve(global::UnityEngine.AnimationCurve curve, float zeroValue, bool loop, global::UnityEngine.Vector2 bounds)
		{
		}

		public void Cache()
		{
		}

		public float Evaluate(float t)
		{
			return 0f;
		}
	}
}
