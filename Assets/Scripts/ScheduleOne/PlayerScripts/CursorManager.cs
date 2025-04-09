using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	public class CursorManager : Singleton<CursorManager>
	{
		public enum ECursorType
		{
			Default = 0,
			Finger = 1,
			OpenHand = 2,
			Grab = 3,
			Scissors = 4
		}

		[Serializable]
		public class CursorConfig
		{
			public ECursorType CursorType;

			public Texture2D Texture;

			public Vector2 HotSpot;
		}

		[Header("References")]
		public List<CursorConfig> Cursors;

		protected override void Awake()
		{
		}

		public void SetCursorAppearance(ECursorType type)
		{
		}
	}
}
