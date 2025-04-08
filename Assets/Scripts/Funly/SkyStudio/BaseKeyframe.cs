namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class BaseKeyframe : global::System.IComparable, global::Funly.SkyStudio.IBaseKeyframe
	{
		[global::UnityEngine.SerializeField]
		public string m_Id;

		[global::UnityEngine.SerializeField]
		private float m_Time;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.InterpolationCurve m_InterpolationCurve;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.InterpolationDirection m_InterpolationDirection;

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

		public global::Funly.SkyStudio.InterpolationCurve interpolationCurve
		{
			get
			{
				return default(global::Funly.SkyStudio.InterpolationCurve);
			}
			set
			{
			}
		}

		public global::Funly.SkyStudio.InterpolationDirection interpolationDirection
		{
			get
			{
				return default(global::Funly.SkyStudio.InterpolationDirection);
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
