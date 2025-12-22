namespace ScheduleOne.Product
{
	public class ProductConsumeAnimation : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Serialization.FormerlySerializedAs("ConsumeAnimationBool")]
		[global::UnityEngine.SerializeField]
		private string _thirdPersonAnimationBool;

		[global::UnityEngine.Serialization.FormerlySerializedAs("ConsumeAnimationTrigger")]
		[global::UnityEngine.SerializeField]
		private string _thirdPersonAnimationTrigger;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable _thirdPersonEquippable;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController ConsumeSound;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onPrepareStart;

		public global::UnityEngine.Events.UnityEvent onPrepareCancel;

		public global::UnityEngine.Events.UnityEvent onConsume;

		[field: global::UnityEngine.SerializeField]
		public string ConsumeDescription { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float PrepareDuration { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float EffectsApplyDelay { get; private set; }

		public void StartPrepare()
		{
		}

		public void CancelPrepare()
		{
		}

		public void StartConsume()
		{
		}

		public void StopConsume()
		{
		}
	}
}
