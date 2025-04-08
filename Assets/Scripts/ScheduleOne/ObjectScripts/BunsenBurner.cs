namespace ScheduleOne.ObjectScripts
{
	public class BunsenBurner : global::UnityEngine.MonoBehaviour
	{
		public bool LockDial;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Gradient FlameColor;

		public global::UnityEngine.AnimationCurve LightIntensity;

		public float HandleRotationSpeed;

		public global::UnityEngine.AnimationCurve FlamePitch;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.ParticleSystem Flame;

		public global::UnityEngine.Light Light;

		public global::UnityEngine.Transform Handle;

		public global::ScheduleOne.PlayerTasks.Clickable HandleClickable;

		public global::UnityEngine.Transform Handle_Min;

		public global::UnityEngine.Transform Handle_Max;

		public global::UnityEngine.Transform Highlight;

		public global::UnityEngine.Animation Anim;

		public global::ScheduleOne.Audio.AudioSourceController FlameSound;

		public bool Interactable { get; private set; }

		public bool IsDialHeld { get; private set; }

		public float CurrentDialValue { get; private set; }

		public float CurrentHeat { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateEffects()
		{
		}

		public void SetDialPosition(float pos)
		{
		}

		public void SetInteractable(bool e)
		{
		}

		public void ClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		public void ClickEnd()
		{
		}
	}
}
