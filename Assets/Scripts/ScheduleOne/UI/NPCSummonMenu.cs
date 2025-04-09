using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class NPCSummonMenu : Singleton<NPCSummonMenu>
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public RectTransform EntryContainer;

		public RectTransform[] Entries;

		private Action<NPC> callback;

		public bool IsOpen { get; private set; }

		protected override void Start()
		{
		}

		private void Exit(ExitAction exit)
		{
		}

		public void Open(List<NPC> npcs, Action<NPC> _callback)
		{
		}

		public void Close()
		{
		}

		public void NPCSelected(NPC npc)
		{
		}
	}
}
