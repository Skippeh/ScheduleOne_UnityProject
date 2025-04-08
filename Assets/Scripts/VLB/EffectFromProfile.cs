namespace VLB
{
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-effect-from-profile/")]
	public class EffectFromProfile : global::UnityEngine.MonoBehaviour
	{
		public const string ClassName = "EffectFromProfile";

		[global::UnityEngine.SerializeField]
		private global::VLB.EffectAbstractBase m_EffectProfile;

		private global::VLB.EffectAbstractBase m_EffectInstance;

		public global::VLB.EffectAbstractBase effectProfile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void InitInstanceFromProfile()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
