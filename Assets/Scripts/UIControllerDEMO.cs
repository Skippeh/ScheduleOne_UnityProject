using System.Collections.Generic;
using AdvancedPeopleSystem;
using UnityEngine;
using UnityEngine.UI;

public class UIControllerDEMO : MonoBehaviour
{
	[Space(5f)]
	[Header("I do not recommend using it in your projects")]
	[Header("This script was created to demonstrate api")]
	public CharacterCustomization CharacterCustomization;

	[Space(15f)]
	public Text playbutton_text;

	public Text bake_text;

	public Text lod_text;

	public Text panelNameText;

	public Slider fatSlider;

	public Slider musclesSlider;

	public Slider thinSlider;

	public Slider slimnessSlider;

	public Slider breastSlider;

	public Slider heightSlider;

	public Slider legSlider;

	public Slider headSizeSlider;

	public Slider headOffsetSlider;

	public Slider[] faceShapeSliders;

	public RectTransform HairPanel;

	public RectTransform BeardPanel;

	public RectTransform ShirtPanel;

	public RectTransform PantsPanel;

	public RectTransform ShoesPanel;

	public RectTransform HatPanel;

	public RectTransform AccessoryPanel;

	public RectTransform BackpackPanel;

	public RectTransform FaceEditPanel;

	public RectTransform BaseEditPanel;

	public RectTransform SkinColorPanel;

	public RectTransform EyeColorPanel;

	public RectTransform HairColorPanel;

	public RectTransform UnderpantsColorPanel;

	public RectTransform EmotionsPanel;

	public RectTransform SavesPanel;

	public RectTransform SavesPanelList;

	public RectTransform SavesPrefab;

	public List<RectTransform> SavesList;

	public Image SkinColorButtonColor;

	public Image EyeColorButtonColor;

	public Image HairColorButtonColor;

	public Image UnderpantsColorButtonColor;

	public Vector3[] CameraPositionForPanels;

	public Vector3[] CameraEulerForPanels;

	private int currentPanelIndex;

	public Camera Camera;

	public RectTransform femaleUI;

	public RectTransform maleUI;

	private int lodIndex;

	private bool walk_active;

	private bool canvasVisible;

	public void SwitchCharacterSettings(string name)
	{
	}

	public void ShowFaceEdit()
	{
	}

	public void ShowBaseEdit()
	{
	}

	public void SetFaceShape(int index)
	{
	}

	public void SetHeadOffset()
	{
	}

	public void BodyFat()
	{
	}

	public void BodyMuscles()
	{
	}

	public void BodyThin()
	{
	}

	public void BodySlimness()
	{
	}

	public void BodyBreast()
	{
	}

	public void SetHeight()
	{
	}

	public void SetHeadSize()
	{
	}

	public void Lod_Event(int next)
	{
	}

	public void SetNewSkinColor(Color color)
	{
	}

	public void SetNewEyeColor(Color color)
	{
	}

	public void SetNewHairColor(Color color)
	{
	}

	public void SetNewUnderpantsColor(Color color)
	{
	}

	public void VisibleSkinColorPanel(bool v)
	{
	}

	public void VisibleEyeColorPanel(bool v)
	{
	}

	public void VisibleHairColorPanel(bool v)
	{
	}

	public void VisibleUnderpantsColorPanel(bool v)
	{
	}

	public void ShirtPanel_Select(bool v)
	{
	}

	public void PantsPanel_Select(bool v)
	{
	}

	public void ShoesPanel_Select(bool v)
	{
	}

	public void BackpackPanel_Select(bool v)
	{
	}

	public void HairPanel_Select(bool v)
	{
	}

	public void BeardPanel_Select(bool v)
	{
	}

	public void HatPanel_Select(bool v)
	{
	}

	public void EmotionsPanel_Select(bool v)
	{
	}

	public void AccessoryPanel_Select(bool v)
	{
	}

	public void SavesPanel_Select(bool v)
	{
	}

	public void SaveSelect(int index)
	{
	}

	public void EmotionsChange_Event(int index)
	{
	}

	public void HairChange_Event(int index)
	{
	}

	public void BeardChange_Event(int index)
	{
	}

	public void ShirtChange_Event(int index)
	{
	}

	public void PantsChange_Event(int index)
	{
	}

	public void ShoesChange_Event(int index)
	{
	}

	public void BackpackChange_Event(int index)
	{
	}

	public void HatChange_Event(int index)
	{
	}

	public void AccessoryChange_Event(int index)
	{
	}

	public void HideAllPanels()
	{
	}

	public void SaveToFile()
	{
	}

	public void ClearFromFile()
	{
	}

	public void Randimize()
	{
	}

	public void PlayAnim()
	{
	}

	private void Update()
	{
	}
}
