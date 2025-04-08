namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class KeyframeGroup<T> : global::Funly.SkyStudio.IKeyframeGroup where T : global::Funly.SkyStudio.IBaseKeyframe
	{
		public global::System.Collections.Generic.List<T> keyframes;

		[global::UnityEngine.SerializeField]
		private string m_Name;

		[global::UnityEngine.SerializeField]
		private string m_Id;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public KeyframeGroup(string name)
		{
		}

		public void AddKeyFrame(T keyFrame)
		{
		}

		public void RemoveKeyFrame(T keyFrame)
		{
		}

		public void RemoveKeyFrame(global::Funly.SkyStudio.IBaseKeyframe keyframe)
		{
		}

		public int GetKeyFrameCount()
		{
			return 0;
		}

		public T GetKeyframe(int index)
		{
			return default(T);
		}

		public void SortKeyframes()
		{
		}

		public float CurveAdjustedBlendingTime(global::Funly.SkyStudio.InterpolationCurve curve, float t)
		{
			return 0f;
		}

		public T GetPreviousKeyFrame(float time)
		{
			return default(T);
		}

		public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe)
		{
			beforeKeyframe = default(T);
			afterKeyframe = default(T);
			return false;
		}

		public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex)
		{
			beforeIndex = default(int);
			afterIndex = default(int);
			return false;
		}

		public static float ProgressBetweenSurroundingKeyframes(float time, global::Funly.SkyStudio.BaseKeyframe beforeKey, global::Funly.SkyStudio.BaseKeyframe afterKey)
		{
			return 0f;
		}

		public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime)
		{
			return 0f;
		}

		public static float WidthBetweenCircularValues(float begin, float end)
		{
			return 0f;
		}

		public void TrimToSingleKeyframe()
		{
		}

		public global::Funly.SkyStudio.InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return default(global::Funly.SkyStudio.InterpolationDirection);
		}

		public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
			forwardDistance = default(float);
			reverseDistance = default(float);
		}

		public float InterpolateFloat(global::Funly.SkyStudio.InterpolationCurve curve, global::Funly.SkyStudio.InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return 0f;
		}

		public float AutoInterpolation(float curvedTime, float previousValue, float nextValue)
		{
			return 0f;
		}

		public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			return 0f;
		}

		public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			return 0f;
		}
	}
}
