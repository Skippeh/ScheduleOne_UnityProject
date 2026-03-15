namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "EffectSettings", menuName = "ScriptableObjects/Effects/Effect Settings")]
	public class EffectSettings : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.Header("Numeric Parameters")]
		[global::UnityEngine.SerializeField]
		private string _handlerId;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Effects.EffectItem> _effectItems;

		public string Id => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.EffectItem> EffectItems => null;
	}
}
