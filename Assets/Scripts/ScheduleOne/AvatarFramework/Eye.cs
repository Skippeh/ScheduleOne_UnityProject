using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	public class Eye : MonoBehaviour
	{
		[Serializable]
		public struct EyeLidConfiguration
		{
			[Range(0f, 1f)]
			public float topLidOpen;

			[Range(0f, 1f)]
			public float bottomLidOpen;

			public override string ToString()
			{
				return null;
			}

			public static EyeLidConfiguration Lerp(EyeLidConfiguration start, EyeLidConfiguration end, float lerp)
			{
				return default(EyeLidConfiguration);
			}
		}

		public const float PupilLookSpeed = 10f;

		private static Vector3 defaultScale;

		private static Vector3 maxRotation;

		private static Vector3 minRotation;

		[Header("References")]
		public Transform Container;

		public Transform TopLidContainer;

		public Transform BottomLidContainer;

		public Transform PupilContainer;

		public MeshRenderer TopLidRend;

		public MeshRenderer BottomLidRend;

		public MeshRenderer EyeBallRend;

		public Transform EyeLookOrigin;

		public OptimizedLight EyeLight;

		public SkinnedMeshRenderer PupilRend;

		private Coroutine blinkRoutine;

		private Coroutine stateRoutine;

		private Avatar avatar;

		private Color defaultEyeColor;

		public Vector2 AngleOffset;

		public EyeLidConfiguration CurrentConfiguration { get; protected set; }

		public bool IsBlinking => false;

		private void Awake()
		{
		}

		public void SetSize(float size)
		{
		}

		public void SetLidColor(Color color)
		{
		}

		public void SetEyeballMaterial(Material mat, Color col)
		{
		}

		public void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
		}

		public void ResetEyeballColor()
		{
		}

		public void ConfigureEyeLight(Color color, float intensity)
		{
		}

		public void SetDilation(float dil)
		{
		}

		public void SetEyeLidState(EyeLidConfiguration config, float time)
		{
		}

		private void StopExistingRoutines()
		{
		}

		public void SetEyeLidState(EyeLidConfiguration config, bool debug = false)
		{
		}

		public void LookAt(Vector3 position, bool instant = false)
		{
		}

		public void Blink(float blinkDuration, EyeLidConfiguration endState, bool debug = false)
		{
		}
	}
}
