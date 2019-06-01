using UnityEngine;
using System.Collections;

public class Minion : Card
{
    #region Utils
    
    #endregion

    #region Variables
    private int health;
    private int maxHealth;
    private int attack;
    private int movementPoints;
    private int attackRange;
    private GameUtils.Tribe tribe;
    private GameUtils.State minionState;
    private Ability ability;
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
            if(health + value > MaxHealth)
            {
                health = MaxHealth;
            }
            else
            {
                health = value;
            }
            if(GameUtils.IsZeroOrNegative(health))
            {
                KillMinion();
            }
        }       
    }
    public int MaxHealth
    {
        get
        {
            return MaxHealth;
        }
        set
        {
            maxHealth = value;
            if(GameUtils.IsZeroOrNegative(maxHealth))
            {
                KillMinion();
            }
        }
    }
    public int Attack
    {
        get
        {
            return attack;
        }
        set
        {
            attack = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }
    public int MovementPoints
    {
        get
        {
            return movementPoints;
        }
        set
        {
            movementPoints = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }
    public int AttackRange
    {
        get
        {
            return attackRange;
        }
        set
        {
            attackRange = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }
    public GameUtils.Tribe Tribe
    {
        get
        {
            return tribe;
        }
        set
        {
            tribe = value;
        }
    }
    public GameUtils.State MinionState
    {
        get { return minionState; }
        set { minionState = value; }
    }
    public Ability Ability
    {
        get
        {
            return ability;
        }
        set
        {
            ability = value;
        }
    }
    #endregion

    #region Methods
    public void KillMinion()
    {
        MinionState = GameUtils.State.Dead;
    }

    public void TakeDamage(int value)
    {
        Health -= value;
    }

    public void Heal(int value)
    {
        Health += value;
    }
    
    #endregion
}
