namespace ScheduleOne.AvatarFramework
{
	public class Eye : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public struct EyeLidConfiguration
		{
			[global::UnityEngine.Range(0f, 1f)]
			public float topLidOpen;

			[global::UnityEngine.Range(0f, 1f)]
			public float bottomLidOpen;

			public override string ToString()
			{
				return null;
			}

			public static global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration Lerp(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration start, global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration end, float lerp)
			{
				return default(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration);
			}
		}

		public const float PupilLookSpeed = 10f;

		private static global::UnityEngine.Vector3 defaultScale;

		private static global::UnityEngine.Vector3 maxRotation;

		private static global::UnityEngine.Vector3 minRotation;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Container;

		public global::UnityEngine.Transform TopLidContainer;

		public global::UnityEngine.Transform BottomLidContainer;

		public global::UnityEngine.Transform PupilContainer;

		public global::UnityEngine.MeshRenderer TopLidRend;

		public global::UnityEngine.MeshRenderer BottomLidRend;

		public global::UnityEngine.MeshRenderer EyeBallRend;

		public global::UnityEngine.Transform EyeLookOrigin;

		public global::ScheduleOne.DevUtilities.OptimizedLight EyeLight;

		public global::UnityEngine.SkinnedMeshRenderer PupilRend;

		private global::UnityEngine.Coroutine blinkRoutine;

		private global::UnityEngine.Coroutine stateRoutine;

		private global::ScheduleOne.AvatarFramework.Avatar avatar;

		private global::UnityEngine.Color defaultEyeColor;

		public global::UnityEngine.Vector2 AngleOffset;

		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration CurrentConfiguration { get; protected set; }

		public bool IsBlinking => false;

		private void Awake()
		{
		}

		public void SetSize(float size)
		{
		}

		public void SetLidColor(global::UnityEngine.Color color)
		{
		}

		public void SetEyeballMaterial(global::UnityEngine.Material mat)
		{
		}

		public void SetEyeballColor(global::UnityEngine.Color col, float emission = 0.115f, bool writeDefault = true)
		{
		}

		public void ResetEyeballColor()
		{
		}

		public void ConfigureEyeLight(global::UnityEngine.Color color, float intensity)
		{
		}

		public void SetDilation(float dil)
		{
		}

		public void SetEyeLidState(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration config, float time)
		{
		}

		private void StopExistingRoutines()
		{
		}

		public void SetEyeLidState(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration config, bool debug = false)
		{
		}

		public void LookAt(global::UnityEngine.Vector3 position, bool instant = false)
		{
		}

		public void Blink(float blinkDuration, global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration endState, bool debug = false)
		{
		}
	}
}
