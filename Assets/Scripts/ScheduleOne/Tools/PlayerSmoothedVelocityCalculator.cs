namespace ScheduleOne.Tools
{
	public class PlayerSmoothedVelocityCalculator : global::ScheduleOne.Tools.SmoothedVelocityCalculator
	{
		public global::ScheduleOne.PlayerScripts.Player Player;

		public override global::UnityEngine.Vector3 Velocity => default(global::UnityEngine.Vector3);
	}
}
