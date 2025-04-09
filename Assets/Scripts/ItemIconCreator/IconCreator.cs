using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ItemIconCreator
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[DisallowMultipleComponent]
	public class IconCreator : MonoBehaviour
	{
		public enum SaveLocation
		{
			persistentDataPath = 0,
			dataPath = 1,
			projectFolder = 2,
			custom = 3
		}

		public enum Mode
		{
			Automatic = 0,
			Manual = 1
		}

		[CompilerGenerated]
		private sealed class _003CCaptureFrame_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IconCreator _003C_003E4__this;

			public string objectName;

			public int i;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCaptureFrame_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		protected bool isCreatingIcons;

		public bool useDafaultName;

		public bool includeResolutionInFileName;

		public string iconFileName;

		public SaveLocation pathLocation;

		public Mode mode;

		public string folderName;

		public bool useTransparency;

		public bool lookAtObjectCenter;

		public bool dynamicFov;

		public float fovOffset;

		protected string finalPath;

		private Vector3 mousePostion;

		public KeyCode nextIconKey;

		protected bool CanMove;

		public bool preview;

		protected Camera whiteCam;

		protected Camera blackCam;

		public Camera mainCam;

		protected Texture2D texBlack;

		protected Texture2D texWhite;

		protected Texture2D finalTexture;

		private CameraClearFlags originalClearFlags;

		protected Transform currentObject;

		private void Awake()
		{
		}

		protected void Initialize()
		{
		}

		protected void DeleteCameras()
		{
		}

		public virtual void BuildIcons()
		{
		}

		[IteratorStateMachine(typeof(_003CCaptureFrame_003Ed__30))]
		protected IEnumerator CaptureFrame(string objectName, int i)
		{
			return null;
		}

		protected virtual void Update()
		{
		}

		private void RenderCamToTexture(Camera cam, Texture2D tex)
		{
		}

		private void CreateBlackAndWhiteCameras()
		{
		}

		protected void CreateNewFolderForIcons()
		{
		}

		public string GetFinalFolder()
		{
			return null;
		}

		private void WriteScreenImageToTexture(Texture2D tex)
		{
		}

		private void CalculateOutputTexture()
		{
		}

		private void SavePng(string name, int i)
		{
		}

		public string GetFileName(string name, int i)
		{
			return null;
		}

		private void CacheAndInitialiseFields()
		{
		}

		protected void UpdateFOV(GameObject targetItem)
		{
		}

		protected void UpdateFOV(float value)
		{
		}

		protected void LookAtTargetCenter(GameObject targetItem)
		{
		}

		private float GetTargetFov(GameObject a)
		{
			return 0f;
		}

		private List<Renderer> GetRenderers(GameObject obj)
		{
			return null;
		}

		private Vector3 GetMeshCenter(GameObject a)
		{
			return default(Vector3);
		}

		protected void RevealInFinder()
		{
		}

		public virtual bool CheckConditions()
		{
			return false;
		}

		private string GetBaseLocation()
		{
			return null;
		}

		private void OnValidate()
		{
		}
	}
}
