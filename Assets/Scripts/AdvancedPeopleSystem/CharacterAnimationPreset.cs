using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class CharacterAnimationPreset
	{
		public string name;

		public List<BlendshapeEmotionValue> blendshapes;

		public bool UseGlobalBlendCurve;

		public AnimationCurve GlobalBlendAnimationCurve;

		[HideInInspector]
		public float AnimationPlayDuration;

		[HideInInspector]
		public float weightPower;

		[Header("May decrease performance")]
		public bool applyToAllCharacterMeshes;
	}
}
