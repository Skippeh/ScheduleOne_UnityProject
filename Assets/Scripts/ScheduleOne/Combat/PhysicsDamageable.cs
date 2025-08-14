namespace ScheduleOne.Combat
{
	public class PhysicsDamageable : global::UnityEngine.MonoBehaviour, global::ScheduleOne.Combat.IDamageable
	{
		public const int VELOCITY_HISTORY_LENGTH = 4;

		public global::UnityEngine.Rigidbody Rb;

		public float ForceMultiplier;

		private global::System.Collections.Generic.List<int> impactHistory;

		public global::System.Action<global::ScheduleOne.Combat.Impact> onImpacted;

		private global::System.Collections.Generic.List<global::UnityEngine.Vector3> velocityHistory;

		public global::UnityEngine.Vector3 averageVelocity { get; private set; }

		global::UnityEngine.GameObject global::ScheduleOne.Combat.IDamageable.gameObject => null;

		public void OnValidate()
		{
		}

		public virtual void SendImpact(global::ScheduleOne.Combat.Impact impact)
		{
		}

		public virtual void ReceiveImpact(global::ScheduleOne.Combat.Impact impact)
		{
		}
	}
}
