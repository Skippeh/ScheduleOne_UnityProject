namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarIKController : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::RootMotion.FinalIK.BipedIK BodyIK;

		private global::UnityEngine.Transform defaultLeftLegBendTarget;

		private global::UnityEngine.Transform defaultRightLegBendTarget;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetIKActive(bool active)
		{
		}

		public void OverrideLegBendTargets(global::UnityEngine.Transform leftLegTarget, global::UnityEngine.Transform rightLegTarget)
		{
		}

		public void ResetLegBendTargets()
		{
		}
	}
}
