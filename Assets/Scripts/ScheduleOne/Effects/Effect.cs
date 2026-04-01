namespace ScheduleOne.Effects
{
	public abstract class Effect : global::UnityEngine.ScriptableObject
	{
		public string Name;

		public string Description;

		public string ID;

		[global::UnityEngine.Range(1f, 5f)]
		public int Tier;

		[global::UnityEngine.Range(0f, 1f)]
		public float Addictiveness;

		public global::UnityEngine.Color ProductColor;

		public global::UnityEngine.Color LabelColor;

		public bool ImplementedPriorMixingRework;

		[global::UnityEngine.Header("Value")]
		[global::UnityEngine.Range(-100f, 100f)]
		public int ValueChange;

		[global::UnityEngine.Range(0f, 2f)]
		public float ValueMultiplier;

		[global::UnityEngine.Range(-1f, 1f)]
		public float AddBaseValueMultiple;

		public global::UnityEngine.Vector2 MixDirection;

		public float MixMagnitude;

		public virtual void ApplyToNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public virtual void ClearFromNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public abstract void ApplyToPlayer(global::ScheduleOne.PlayerScripts.Player player);

		public abstract void ClearFromPlayer(global::ScheduleOne.PlayerScripts.Player player);

		protected virtual void ApplyToEmployee(global::ScheduleOne.Employees.Employee employee)
		{
		}

		protected virtual void ClearFromEmployee(global::ScheduleOne.Employees.Employee employee)
		{
		}

		public void OnValidate()
		{
		}
	}
}
