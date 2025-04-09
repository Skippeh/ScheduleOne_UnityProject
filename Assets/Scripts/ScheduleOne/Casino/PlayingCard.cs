using System;
using EasyButtons;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Casino
{
	public class PlayingCard : MonoBehaviour
	{
		[Serializable]
		public class CardSprite
		{
			public ECardSuit Suit;

			public ECardValue Value;

			public Sprite Sprite;
		}

		public struct CardData
		{
			public ECardSuit Suit;

			public ECardValue Value;

			public CardData(ECardSuit suit, ECardValue value)
			{
				this.Suit = suit;
				this.Value = value;
			}
		}

		public enum ECardSuit
		{
			Spades = 0,
			Hearts = 1,
			Diamonds = 2,
			Clubs = 3
		}

		public enum ECardValue
		{
			Blank = 0,
			Ace = 1,
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			Six = 6,
			Seven = 7,
			Eight = 8,
			Nine = 9,
			Ten = 10,
			Jack = 11,
			Queen = 12,
			King = 13
		}

		public string CardID;

		[Header("References")]
		public SpriteRenderer CardSpriteRenderer;

		public CardSprite[] CardSprites;

		public Animation FlipAnimation;

		public AnimationClip FlipFaceUpClip;

		public AnimationClip FlipFaceDownClip;

		[Header("Sound")]
		public AudioSourceController FlipSound;

		public AudioSourceController LandSound;

		private Coroutine moveRoutine;

		private Tuple<Vector3, Quaternion> lastGlideTarget;

		public bool IsFaceUp { get; private set; }

		public ECardSuit Suit { get; private set; }

		public ECardValue Value { get; private set; }

		public CardController CardController { get; private set; }

		private void OnValidate()
		{
		}

		public void SetCardController(CardController cardController)
		{
		}

		public void SetCard(ECardSuit suit, ECardValue value, bool network = true)
		{
		}

		public void ClearCard()
		{
		}

		public void SetFaceUp(bool faceUp, bool network = true)
		{
		}

		public void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
		}

		private CardSprite GetCardSprite(ECardSuit suit, ECardValue val)
		{
			return null;
		}

		[Button]
		public void VerifyCardSprites()
		{
		}
	}
}
