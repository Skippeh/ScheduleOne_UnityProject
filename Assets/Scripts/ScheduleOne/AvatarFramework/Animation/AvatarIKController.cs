using RootMotion.FinalIK;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarIKController : MonoBehaviour
	{
		[Header("References")]
		public BipedIK BodyIK;

		private Transform defaultLeftLegBendTarget;

		private Transform defaultRightLegBendTarget;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetIKActive(bool active)
		{
		}

		public void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
		}

		public void ResetLegBendTargets()
		{
		}
	}
}
