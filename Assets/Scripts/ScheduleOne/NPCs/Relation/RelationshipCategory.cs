using UnityEngine;

namespace ScheduleOne.NPCs.Relation
{
	public class RelationshipCategory
	{
		public static Color32 Hostile_Color;

		public static Color32 Unfriendly_Color;

		public static Color32 Neutral_Color;

		public static Color32 Friendly_Color;

		public static Color32 Loyal_Color;

		public static ERelationshipCategory GetCategory(float delta)
		{
			return default(ERelationshipCategory);
		}

		public static Color32 GetColor(ERelationshipCategory category)
		{
			return default(Color32);
		}
	}
}
