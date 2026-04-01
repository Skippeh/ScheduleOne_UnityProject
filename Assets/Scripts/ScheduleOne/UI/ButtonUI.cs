namespace ScheduleOne.UI
{
	public class ButtonUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button _button;

		private int _id;

		public global::System.Action<int> OnSelect;

		public global::UnityEngine.UI.Button Button => null;

		public void Initialize(int id)
		{
		}
	}
}
