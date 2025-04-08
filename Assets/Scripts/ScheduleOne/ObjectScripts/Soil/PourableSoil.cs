namespace ScheduleOne.ObjectScripts.Soil
{
	public class PourableSoil : global::ScheduleOne.PlayerTasks.Pourable
	{
		public const float TEAR_ANGLE = 10f;

		public const float HIGHLIGHT_CYCLE_TIME = 5f;

		public bool IsOpen;

		public global::ScheduleOne.ItemFramework.SoilDefinition SoilDefinition;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform SoilBag;

		public global::UnityEngine.Transform[] Bones;

		public global::System.Collections.Generic.List<global::UnityEngine.Collider> TopColliders;

		public global::UnityEngine.MeshRenderer[] Highlights;

		public global::UnityEngine.Transform TopParent;

		public global::ScheduleOne.Audio.AudioSourceController SnipSound;

		public global::UnityEngine.SkinnedMeshRenderer TopMesh;

		public global::UnityEngine.Events.UnityEvent onOpened;

		private global::UnityEngine.Vector3 highlightScale;

		private float timeSinceStart;

		public int currentCut { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateHighlights()
		{
		}

		protected override void PourAmount(float amount)
		{
		}

		protected override bool CanPour()
		{
			return false;
		}

		public void Cut()
		{
		}

		private void FinishCut()
		{
		}

		private void LerpCut(int cutIndex)
		{
		}
	}
}
