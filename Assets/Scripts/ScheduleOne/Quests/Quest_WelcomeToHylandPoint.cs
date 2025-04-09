using EasyButtons;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	public class Quest_WelcomeToHylandPoint : Quest
	{
		public QuestEntry ReturnToRVQuest;

		public QuestEntry ReadMessagesQuest;

		public RV RV;

		public UncleNelson Nelson;

		[Header("Settings")]
		public float ExplosionMaxDist;

		public float ExplosionMinDist;

		public UnityEvent onExplode;

		private bool exploded;

		private float cameraLookTime;

		protected override void MinPass()
		{
		}

		private void Update()
		{
		}

		[Button]
		public void Explode()
		{
		}

		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}
	}
}
