using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Cutscenes
{
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		public List<Cutscene> Cutscenes;

		[Header("Run cutscene by name")]
		[SerializeField]
		private string cutsceneName;

		private Cutscene playingCutscene;

		[Button]
		private void RunCutscene()
		{
		}

		public void Play(string name)
		{
		}

		private void Ended()
		{
		}
	}
}
