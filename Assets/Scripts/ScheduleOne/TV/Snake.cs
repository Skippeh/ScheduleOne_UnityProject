using System.Collections.Generic;
using EasyButtons;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	public class Snake : TVApp
	{
		public enum EGameState
		{
			Ready = 0,
			Playing = 1
		}

		public const int SIZE_X = 20;

		public const int SIZE_Y = 12;

		[Header("Settings")]
		public SnakeTile TilePrefab;

		public float TimePerTile;

		[Header("References")]
		public RectTransform PlaySpace;

		public SnakeTile[] Tiles;

		public TextMeshProUGUI ScoreText;

		private Vector2 lastFoodPosition;

		private float _timeSinceLastMove;

		private float _timeOnGameOver;

		public UnityEvent onStart;

		public UnityEvent onEat;

		public UnityEvent onGameOver;

		public UnityEvent onWin;

		public Vector2 HeadPosition { get; private set; }

		public List<Vector2> Tail { get; private set; }

		public Vector2 LastTailPosition { get; private set; }

		public Vector2 Direction { get; private set; }

		public Vector2 QueuedDirection { get; private set; }

		public Vector2 NextDirection { get; private set; }

		public EGameState GameState { get; private set; }

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateInput()
		{
		}

		private void UpdateMovement()
		{
		}

		private void MoveSnake()
		{
		}

		private SnakeTile GetTile(Vector2 position)
		{
			return null;
		}

		private void StartGame(Vector2 initialDir)
		{
		}

		private void Eat()
		{
		}

		private void SpawnFood()
		{
		}

		private void GameOver()
		{
		}

		private void Win()
		{
		}

		protected override void TryPause()
		{
		}

		[Button]
		public void CreateTiles()
		{
		}
	}
}
