using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	[Serializable]
	[CreateAssetMenu(fileName = "BasicAvatarSettings", menuName = "ScriptableObjects/BasicAvatarSettings", order = 1)]
	public class BasicAvatarSettings : ScriptableObject
	{
		public const float GENDER_MULTIPLIER = 0.7f;

		public const string MaleUnderwearPath = "Avatar/Layers/Bottom/MaleUnderwear";

		public const string FemaleUnderwearPath = "Avatar/Layers/Bottom/FemaleUnderwear";

		public int Gender;

		public float Weight;

		public Color SkinColor;

		public string HairStyle;

		public Color HairColor;

		public string Mouth;

		public string FacialHair;

		public string FacialDetails;

		public float FacialDetailsIntensity;

		public Color EyeballColor;

		public float UpperEyeLidRestingPosition;

		public float LowerEyeLidRestingPosition;

		public float PupilDilation;

		public float EyebrowScale;

		public float EyebrowThickness;

		public float EyebrowRestingHeight;

		public float EyebrowRestingAngle;

		public string Top;

		public Color TopColor;

		public string Bottom;

		public Color BottomColor;

		public string Shoes;

		public Color ShoesColor;

		public string Headwear;

		public Color HeadwearColor;

		public string Eyewear;

		public Color EyewearColor;

		public List<string> Tattoos;

		public T SetValue<T>(string fieldName, T value)
		{
			return default(T);
		}

		public T GetValue<T>(string fieldName)
		{
			return default(T);
		}

		public AvatarSettings GetAvatarSettings()
		{
			return null;
		}

		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}
	}
}
