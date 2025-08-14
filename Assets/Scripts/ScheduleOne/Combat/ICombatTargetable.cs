namespace ScheduleOne.Combat
{
	public interface ICombatTargetable : global::ScheduleOne.Combat.IDamageable, global::ScheduleOne.Vision.ISightable
	{
		new global::FishNet.Object.NetworkObject NetworkObject { get; }

		global::UnityEngine.Vector3 CenterPoint => default(global::UnityEngine.Vector3);

		global::UnityEngine.Transform CenterPointTransform { get; }

		global::UnityEngine.Vector3 LookAtPoint { get; }

		bool IsCurrentlyTargetable { get; }

		float RangedHitChanceMultiplier { get; }

		global::UnityEngine.Vector3 Velocity { get; }

		bool IsPlayer => false;

		global::ScheduleOne.PlayerScripts.Player AsPlayer => null;

		void RecordLastKnownPosition(bool resetTimeSinceLastSeen);

		float GetSearchTime();
	}
}
