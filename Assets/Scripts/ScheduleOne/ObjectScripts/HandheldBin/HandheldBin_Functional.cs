namespace ScheduleOne.ObjectScripts.HandheldBin
{
	public class HandheldBin_Functional : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform trash;

		[global::UnityEngine.Header("Settings")]
		public float trash_MinY;

		public float trash_MaxY;

		public float fillLevel { get; protected set; }

		protected virtual void Awake()
		{
		}

		public void SetAmount(float amount)
		{
		}

		protected virtual void UpdateTrashVisuals()
		{
		}
	}
}
