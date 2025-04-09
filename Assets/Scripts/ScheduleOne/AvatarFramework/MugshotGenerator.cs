using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		public string OutputPath;

		public AvatarSettings Settings;

		[Header("References")]
		public Avatar MugshotRig;

		public IconGenerator Generator;

		public AvatarSettings DefaultSettings;

		public Transform LookAtPosition;

		private Texture2D finalTexture;

		private bool generate;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void FinalizeMugshot()
		{
		}

		[Button]
		public void GenerateMugshot()
		{
		}

		public void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)
		{
		}
	}
}
