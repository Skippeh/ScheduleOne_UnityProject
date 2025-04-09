using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne
{
	public class Console : Singleton<Console>
	{
		public abstract class ConsoleCommand
		{
			public abstract string CommandWord { get; }

			public abstract string CommandDescription { get; }

			public abstract string ExampleUsage { get; }

			public abstract void Execute(List<string> args);
		}

		public class SetTimeCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SpawnVehicleCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class AddItemToInventoryCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ClearInventoryCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ChangeCashCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ChangeOnlineBalanceCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetMoveSpeedCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetJumpMultiplier : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetPropertyOwned : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class Teleport : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class PackageProduct : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetStaminaReserve : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class RaisedWanted : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class LowerWanted : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ClearWanted : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetHealth : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetEnergy : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class FreeCamCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class Save : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetTimeScale : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetVariableValue : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetQuestState : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetQuestEntryState : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetEmotion : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetUnlocked : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetRelationship : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class AddEmployeeCommand : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetDiscovered : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class GrowPlants : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetLawIntensity : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class SetQuality : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class Bind : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class Unbind : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ClearBinds : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class HideUI : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class GiveXP : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class Disable : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class Enable : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class EndTutorial : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class DisableNPCAsset : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ShowFPS : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class HideFPS : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		public class ClearTrash : ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(List<string> args)
			{
			}
		}

		[Serializable]
		public class LabelledGameObject
		{
			public string Label;

			public GameObject GameObject;
		}

		public Transform TeleportPointsContainer;

		public List<LabelledGameObject> LabelledGameObjectList;

		[Tooltip("Commands that run on startup (Editor only)")]
		public List<string> startupCommands;

		public static List<ConsoleCommand> Commands;

		private static Dictionary<string, ConsoleCommand> commands;

		private Dictionary<KeyCode, string> keyBindings;

		private static Player player => null;

		private static void LogCommandError(string error)
		{
		}

		private static void LogUnrecognizedFormat(string[] correctExamples)
		{
		}

		protected override void Awake()
		{
		}

		private void RunStartupCommands()
		{
		}

		[HideInCallstack]
		public static void Log(object message, UnityEngine.Object context = null)
		{
		}

		[HideInCallstack]
		public static void LogWarning(object message, UnityEngine.Object context = null)
		{
		}

		[HideInCallstack]
		public static void LogError(object message, UnityEngine.Object context = null)
		{
		}

		public static void SubmitCommand(List<string> args)
		{
		}

		public static void SubmitCommand(string args)
		{
		}

		public void AddBinding(KeyCode key, string command)
		{
		}

		public void RemoveBinding(KeyCode key)
		{
		}

		public void ClearBindings()
		{
		}

		private void Update()
		{
		}
	}
}
