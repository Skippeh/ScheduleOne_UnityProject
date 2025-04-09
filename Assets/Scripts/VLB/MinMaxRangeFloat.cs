using System;
using UnityEngine;

namespace VLB
{
	[Serializable]
	public struct MinMaxRangeFloat : IEquatable<MinMaxRangeFloat>
	{
		[SerializeField]
		private float m_MinValue;

		[SerializeField]
		private float m_MaxValue;

		public float minValue => 0f;

		public float maxValue => 0f;

		public float randomValue => 0f;

		public Vector2 asVector2 => default(Vector2);

		public float GetLerpedValue(float lerp01)
		{
			return 0f;
		}

		public MinMaxRangeFloat(float min, float max)
		{
			m_MinValue = min;
			m_MaxValue = max;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(MinMaxRangeFloat other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			return false;
		}

		public static bool operator !=(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			return false;
		}
	}
}
