using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-from-profile/")]
	public class EffectFromProfile : MonoBehaviour
	{
		public const string ClassName = "EffectFromProfile";

		[SerializeField]
		private EffectAbstractBase m_EffectProfile;

		private EffectAbstractBase m_EffectInstance;

		public EffectAbstractBase effectProfile
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
