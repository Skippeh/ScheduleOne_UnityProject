using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class KeyframeGroup<T> : IKeyframeGroup where T : IBaseKeyframe
	{
		public List<T> keyframes;

		[SerializeField]
		private string m_Name;

		[SerializeField]
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

		public void RemoveKeyFrame(IBaseKeyframe keyframe)
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

		public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t)
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

		public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey)
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

		public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return default(InterpolationDirection);
		}

		public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
			forwardDistance = default(float);
			reverseDistance = default(float);
		}

		public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
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
