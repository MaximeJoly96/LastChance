using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    #region Variables
    private int health;
    private int maxHealth;
    private int mana;
    private int maxMana;
    private int fatigueDmg;

    private GameUtils.Classes hero;
    private GameUtils.State state;
    private List<Card> deck;
    private List<Card> graveyard;
    private List<Card> hand;
    #endregion

    #region Properties
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if (health + value > MaxHealth)
            {
                health = MaxHealth;
            }
            else
            {
                health = value;
            }
            if (GameUtils.IsZeroOrNegative(health))
            {
                KillHero();
            }
        }
    }
    public int MaxHealth
    {
        get
        {
            return maxHealth;
        }
        set
        {
            maxHealth = value;
            if (GameUtils.IsZeroOrNegative(maxHealth))
            {
                KillHero();
            }
        }
    }
    public int Mana
    {
        get
        {
            return mana;
        }
        set
        {
            mana = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }
    public int MaxMana
    {
        get
        {
            return maxMana;
        }
        set
        {
            maxMana = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }
    public int FatigueDmg
    {
        get
        {
            return fatigueDmg;
        }
        set
        {
            fatigueDmg = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }

    public GameUtils.Classes Hero
    {
        get
        {
            return hero;
        }
        set
        {
            if(value == GameUtils.Classes.Neutral)
            {
                Debug.LogError("Tried to assign Neutral class to Hero, which is not allowed. Assigned Bellum class instead.");
                hero = GameUtils.Classes.Bellum;
            }
            else
            {
                hero = value;
            }          
        }
    }
    public GameUtils.State State
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
        }
    }

    public List<Card> Deck
    {
        get
        {
            return deck;
        }
        set
        {
            deck = value;
        }
    }
    public List<Card> Graveyard
    {
        get
        {
            return graveyard;
        }
        set
        {
            graveyard = value;
        }
    }
    public List<Card> Hand
    {
        get
        {
            return hand;
        }
        set
        {
            hand = value;
        }
    }
    #endregion

    #region Methods
    public void KillHero()
    {
        this.State = GameUtils.State.Dead;
    }
    public void DrawCardFromDeck(Card card)
    {
        if(IsDeckEmpty())
        {
            IncreaseFatigueDmg();
            TakeDamage(FatigueDmg);
        }
        else
        {
            if(IsHandFull())
            {
                Graveyard.Add(card);
            }
            else
            {
                Hand.Add(card);
            }
            Deck.Remove(card);
        }
    }

    public void IncreaseFatigueDmg()
    {
        FatigueDmg++;
    }
    public bool IsDeckEmpty()
    {
        return Deck.Count <= 0;
    }
    public void TakeDamage(int value)
    {
        Health -= value;
    }
    public void Heal(int value)
    {
        Health += value;
    }
    public bool IsHandFull()
    {
        return Hand.Count >= GameUtils.MAX_CARDS_IN_HAND;
    }
    #endregion

}
