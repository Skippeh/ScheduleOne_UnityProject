namespace ScheduleOne.Product
{
	public class FirstPersonProductConsumeAnimation : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string ConsumeDescription;

		public float ConsumeTime;

		public float EffectsApplyDelay;

		public string ConsumeAnimationBool;

		public string ConsumeAnimationTrigger;

		public string ConsumeEquippableAssetPath;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onPrepareStart;

		public global::UnityEngine.Events.UnityEvent onPrepareCancel;

		public global::UnityEngine.Events.UnityEvent onConsume;

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
