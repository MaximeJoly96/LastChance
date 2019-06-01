using UnityEngine;
using System.Collections;

public class Ability
{
    #region Variables
    private int manaCost;
    private int range;
    private bool alreadyUsed;
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
    public int Range
    {
        get
        {
            return range;
        }
        set
        {
            range = GameUtils.IsZeroOrNegative(value) ? 0 : value;
        }
    }
    public bool AlreadyUsed
    {
        get
        {
            return alreadyUsed;
        }
        set
        {
            alreadyUsed = value;
        }
    }
    #endregion

    #region Methods
    public void Use()
    {
        alreadyUsed = true;
    }
    #endregion
}
