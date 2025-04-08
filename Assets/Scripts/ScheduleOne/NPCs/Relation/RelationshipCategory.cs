namespace ScheduleOne.NPCs.Relation
{
	public class RelationshipCategory
	{
		public static global::UnityEngine.Color32 Hostile_Color;

		public static global::UnityEngine.Color32 Unfriendly_Color;

		public static global::UnityEngine.Color32 Neutral_Color;

		public static global::UnityEngine.Color32 Friendly_Color;

		public static global::UnityEngine.Color32 Loyal_Color;

		public static global::ScheduleOne.NPCs.Relation.ERelationshipCategory GetCategory(float delta)
		{
			return default(global::ScheduleOne.NPCs.Relation.ERelationshipCategory);
		}

		public static global::UnityEngine.Color32 GetColor(global::ScheduleOne.NPCs.Relation.ERelationshipCategory category)
		{
			return default(global::UnityEngine.Color32);
		}
	}
}
