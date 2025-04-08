namespace ScheduleOne.Cutscenes
{
	public class CutsceneManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Cutscenes.CutsceneManager>
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Cutscenes.Cutscene> Cutscenes;

		[global::UnityEngine.Header("Run cutscene by name")]
		[global::UnityEngine.SerializeField]
		private string cutsceneName;

		private global::ScheduleOne.Cutscenes.Cutscene playingCutscene;

		[global::EasyButtons.Button]
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
