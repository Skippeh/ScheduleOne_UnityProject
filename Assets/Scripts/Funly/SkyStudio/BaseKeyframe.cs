using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class BaseKeyframe : IComparable, IBaseKeyframe
	{
		[SerializeField]
		public string m_Id;

		[SerializeField]
		private float m_Time;

		[SerializeField]
		private InterpolationCurve m_InterpolationCurve;

		[SerializeField]
		private InterpolationDirection m_InterpolationDirection;

		public string id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public InterpolationCurve interpolationCurve
		{
			get
			{
				return default(InterpolationCurve);
			}
			set
			{
			}
		}

		public InterpolationDirection interpolationDirection
		{
			get
			{
				return default(InterpolationDirection);
			}
			set
			{
			}
		}

		public BaseKeyframe(float time)
		{
		}

		public int CompareTo(object other)
		{
			return 0;
		}
	}
}
