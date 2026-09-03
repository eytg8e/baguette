using System;
using UnityEngine;

public class ShopState
{
    [SerializeField] private int maxHealthLevel;
    public int MaxHealthLevel => maxHealthLevel;
    [SerializeField] private float maxHealthBasePrice;
    public float MaxHealthBasePrice => maxHealthBasePrice;
    [SerializeField] private float maxHealthPriceStep;
    public float MaxHealthPriceStep => maxHealthPriceStep;

    [SerializeField] private int maxBreadLevel;
    public int MaxBreadLevel => maxBreadLevel;
    [SerializeField] private float maxBreadBasePrice;
    public float MaxBreadBasePrice => maxBreadBasePrice;
    [SerializeField] private float maxBreadPriceStep;
    public float MaxBreadPriceStep => maxBreadPriceStep;

    [SerializeField] private int speedLevel;
    public int SpeedLevel => speedLevel;
    [SerializeField] private float speedBasePrice;
    public float SpeedBasePrice => speedBasePrice;
    [SerializeField] private float speedPriceStep;
    public float SpeedPriceStep => speedPriceStep;

    [SerializeField] private float drinkPrice;
    public float DrinkPrice => drinkPrice;
    [SerializeField] private float butterPrice;
    public float ButterPrice => butterPrice;


    public event Action<int, float, float> OnMaxHealthLevelChanged;
    public event Action<int, float, float> OnMaxBreadLevelChanged;
    public event Action<int, float, float> OnSpeedLevelChanged;

    public void MaxHealthLevelUp()
    {
        maxHealthLevel += 1;
    }

    public float MaxHealthLevelUpPrice()
    {
        return maxHealthBasePrice + maxHealthPriceStep * maxHealthLevel;
    }

    public void MaxBreadLevelUp()
    {
        maxBreadLevel += 1;
    }

    public float MaxBreadLevelUpPrice()
    {
        return maxBreadBasePrice + maxBreadPriceStep * maxBreadLevel;
    }

    public void SpeedLevelUp()
    {
        speedLevel += 1;
    }

    public float SpeedLevelUpPrice()
    {
        return speedBasePrice + speedPriceStep * speedLevel;
    }
}
