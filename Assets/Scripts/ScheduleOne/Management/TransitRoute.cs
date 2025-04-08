namespace ScheduleOne.Management
{
	public class TransitRoute
	{
		protected global::ScheduleOne.Management.TransitLineVisuals visuals;

		public global::System.Action<global::ScheduleOne.Management.ITransitEntity> onSourceChange;

		public global::System.Action<global::ScheduleOne.Management.ITransitEntity> onDestinationChange;

		public global::ScheduleOne.Management.ITransitEntity Source { get; protected set; }

		public global::ScheduleOne.Management.ITransitEntity Destination { get; protected set; }

		public TransitRoute(global::ScheduleOne.Management.ITransitEntity source, global::ScheduleOne.Management.ITransitEntity destination)
		{
		}

		public void Destroy()
		{
		}

		public void SetVisualsActive(bool active)
		{
		}

		private void Update()
		{
		}

		public virtual void SetSource(global::ScheduleOne.Management.ITransitEntity source)
		{
		}

		public bool AreEntitiesNonNull()
		{
			return false;
		}

		public virtual void SetDestination(global::ScheduleOne.Management.ITransitEntity destination)
		{
		}

		private void ValidateEntities()
		{
		}
	}
}
