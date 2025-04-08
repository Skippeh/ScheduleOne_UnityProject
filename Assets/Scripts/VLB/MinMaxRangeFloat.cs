namespace VLB
{
	[global::System.Serializable]
	public struct MinMaxRangeFloat : global::System.IEquatable<global::VLB.MinMaxRangeFloat>
	{
		[global::UnityEngine.SerializeField]
		private float m_MinValue;

		[global::UnityEngine.SerializeField]
		private float m_MaxValue;

		public float minValue => 0f;

		public float maxValue => 0f;

		public float randomValue => 0f;

		public global::UnityEngine.Vector2 asVector2 => default(global::UnityEngine.Vector2);

		public float GetLerpedValue(float lerp01)
		{
			return 0f;
		}

		public MinMaxRangeFloat(float min, float max)
		{
			m_MinValue = 0f;
			m_MaxValue = 0f;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(global::VLB.MinMaxRangeFloat other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(global::VLB.MinMaxRangeFloat lhs, global::VLB.MinMaxRangeFloat rhs)
		{
			return false;
		}

		public static bool operator !=(global::VLB.MinMaxRangeFloat lhs, global::VLB.MinMaxRangeFloat rhs)
		{
			return false;
		}
	}
}
