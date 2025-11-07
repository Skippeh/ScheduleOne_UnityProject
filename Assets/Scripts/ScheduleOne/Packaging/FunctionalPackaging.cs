namespace ScheduleOne.Packaging
{
	public class FunctionalPackaging : global::ScheduleOne.PlayerTasks.Draggable
	{
		[global::UnityEngine.Header("Settings")]
		public string SealInstruction;

		public bool AutoEnableSealing;

		public float ProductContactTime;

		public float ProductContactMaxVelocity;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Product.Packaging.PackagingDefinition Definition;

		public global::UnityEngine.Transform AlignmentPoint;

		public global::UnityEngine.Transform[] ProductAlignmentPoints;

		public global::ScheduleOne.Audio.AudioSourceController SealSound;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Product.FunctionalProduct> PackedProducts;

		public global::System.Action onFullyPacked;

		public global::System.Action onSealed;

		public global::System.Action onReachOutput;

		private global::ScheduleOne.ObjectScripts.PackagingStation station;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Product.FunctionalProduct, float> productContactTime;

		private global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator;

		public bool IsSealed { get; protected set; }

		public bool IsFull { get; protected set; }

		public bool ReachedOutput { get; protected set; }

		public virtual void Initialize(global::ScheduleOne.ObjectScripts.PackagingStation _station, global::UnityEngine.Transform alignment, bool align = true)
		{
		}

		public void AlignTo(global::UnityEngine.Transform alignment)
		{
		}

		public virtual void Destroy()
		{
		}

		protected override void FixedUpdate()
		{
		}

		protected virtual void PackProduct(global::ScheduleOne.Product.FunctionalProduct product)
		{
		}

		protected virtual void FullyPacked()
		{
		}

		protected virtual void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}

		protected virtual void EnableSealing()
		{
		}

		public virtual void Seal()
		{
		}
	}
}
