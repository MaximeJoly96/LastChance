using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    #region Variables
    private int manaCost;
    private int castRange;
    private GameUtils.CardType type;
    private GameUtils.Classes seraphin;
    private GameUtils.Rarity rarity;
    #endregion

    #region Properties
    public int ManaCost
    {
        get
        {
            return manaCost;
        }
        set
        {
            manaCost = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }

    public int CastRange
    {
        get
        {
            return castRange;
        }
        set
        {
            castRange = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }

    public GameUtils.CardType Type
    {
        get { return type; }
        set { type = value; }
    }
    public GameUtils.Classes Seraphin
    {
        get { return seraphin; }
        set { seraphin = value; }
    }
    public GameUtils.Rarity Rarity
    {
        get { return rarity; }
        set { rarity = value; }
    }

    #endregion

    #region Methods

    #endregion
}
