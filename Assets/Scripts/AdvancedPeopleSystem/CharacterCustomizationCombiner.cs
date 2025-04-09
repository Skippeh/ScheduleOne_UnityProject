using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	public class CharacterCustomizationCombiner
	{
		private class MeshInstance
		{
			public Dictionary<Material, List<CombineInstanceWithSM>> combine_instances;

			public List<Material> unique_materials;

			public Mesh combined_new_mesh;

			public List<Vector3> combined_vertices;

			public List<Vector2> combined_uv;

			public List<Vector2> combined_uv2;

			public List<Vector2> combined_uv3;

			public List<Vector2> combined_uv4;

			public List<Vector3> normals;

			public List<Vector4> tangents;

			public Dictionary<Material, List<int>> combined_submesh_indices;

			public List<BoneWeight> combined_bone_weights;

			public List<string> blendShapeNames;

			public List<float> blendShapeValues;

			public Dictionary<Mesh, int> vertex_offset_map;

			public int vertex_index_offset;

			public int current_material_index;
		}

		private struct CombineInstanceWithSM
		{
			public SkinnedMeshRenderer skinnedMesh;

			public CombineInstance instance;
		}

		private struct BlendWeightData
		{
			public Vector3[] deltaVerts;

			public Vector3[] deltaNormals;

			public Vector3[] deltaTangents;
		}

		[CompilerGenerated]
		private sealed class _003CBlendshapeTransfer_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MeshInstance meshInstance;

			public SkinnedMeshRenderer smr;

			public float waitTime;

			public bool yieldUse;

			public int lod;

			private CharacterCustomization _003CcharacterSystem_003E5__2;

			private int _003Cbs_003E5__3;

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
			public _003CBlendshapeTransfer_003Ed__11(int _003C_003E1__state)
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

		private static Matrix4x4[] bindPoses;

		private static List<MeshInstance> LODMeshInstances;

		private static CharacterCustomization currentCharacter;

		private static bool useExportToAnotherObject;

		private static bool BlendshapeTransferWork;

		private static Action<List<SkinnedMeshRenderer>> _callback;

		private static List<SkinnedMeshRenderer> returnSkinnedMeshes;

		public static List<SkinnedMeshRenderer> MakeCombinedMeshes(CharacterCustomization character, GameObject exportInCustomObject = null, float blendshapeAddDelay = 0.001f, Action<List<SkinnedMeshRenderer>> callback = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBlendshapeTransfer_003Ed__11))]
		private static IEnumerator BlendshapeTransfer(MeshInstance meshInstance, float waitTime, SkinnedMeshRenderer smr, int lod, bool yieldUse = true)
		{
			return null;
		}
	}
}
