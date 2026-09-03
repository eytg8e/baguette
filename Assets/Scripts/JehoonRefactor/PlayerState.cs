using System;
using UnityEngine;

public class PlayerState
{

    #region 플레이어 스탯, 레벨업 시 성장치
    [SerializeField] private int currentHP;
    public int CurrentHP => currentHP;
    [SerializeField] private int maxHP;
    public int MaxHP => maxHP;
    [SerializeField] private int healthStep;
    public int HealthStep => healthStep;

    [SerializeField] private float playerSpeed;
    public float PlayerSpeed => playerSpeed;
    [SerializeField] private float speedStep;
    public float SpeedStep => speedStep;

    #endregion

    #region 플레이어 자원 수량, 레벨업 시 성장치 (빵 소지 개수)
    [SerializeField] private int currentBread;
    public int CurrentBread => currentBread;
    [SerializeField] private int maxBread;
    public int MaxBread => maxBread;
    [SerializeField] private int breadStep;
    public int BreadStep => breadStep;

    [SerializeField] private float currentMoney;
    public float CurrentMoney => currentMoney;

    #endregion

    #region 소모품 수량, 효과 지속시간, 효과 배율

    [SerializeField] private int currentDrink;
    public int CurrentDrink => currentDrink;
    [SerializeField] private float durationDrink;
    public float DurationDrink => durationDrink;
    [SerializeField] private float multiplerDrink;
    public float MultiplerDrink => multiplerDrink;
    [SerializeField] private int currentButter;
    public int CurrentButter => currentButter;
    [SerializeField] private float durationButter;
    public float DurationButter => durationButter;
    [SerializeField] private float multiplerButter;
    public float MultiplerButter => multiplerButter;

    #region 플레이어 관련 이벤트 선언

    public event Action<int, int> OnHealthChanged;
    public event Action<int, int> OnBreadChanged;
    public event Action<float> OnSpeedChanged;
    public event Action<float> OnMoneyChanged;
    public event Action<int, bool> OnDrinkChanged;
    public event Action<int, bool> OnButterChanged;
    #endregion


    #endregion

    public void TakeDamage(int amount)
    {
        currentHP -= amount;

        OnHealthChanged?.Invoke(currentHP, maxHP);
    }

    public void Heal(int amount)
    {
        currentHP += amount;

        OnHealthChanged?.Invoke(currentHP, maxHP);
    }

    public void BuyMaxHealth(float price)
    {
        maxHP += healthStep;
        currentHP = maxHP;
        currentMoney -= price;

        OnHealthChanged?.Invoke(currentHP, maxHP);
        OnMoneyChanged?.Invoke(currentMoney);
    }

    public void ThrowBread(int amount)
    {
        currentBread -= amount;

        OnBreadChanged?.Invoke(currentBread, maxBread);
    }
    /// <summary>
    /// 배달 시 빵 수량 감소, 버터 버프 유무 확인 후 보상 금액 지급
    /// </summary>
    /// <param name="amount">배달한 빵 수량</param>
    /// <param name="reward">보상 금액</param>
    /// <param name="isButterEnchanted">버터 버프 적용 여부 확인</param>
    public void DeliverBread(int amount, float reward, bool isButterEnchanted)
    {
        Heal(1);
        if (isButterEnchanted)
        {
            currentMoney += reward * multiplerButter;
        }
        else
        {
            currentMoney += reward;
        }
        currentBread -= amount;

        OnBreadChanged?.Invoke(currentBread, maxBread);
        OnMoneyChanged?.Invoke(currentMoney);
    }

    public void RefillBread()
    {
        currentBread = MaxBread;

        OnBreadChanged?.Invoke(currentBread, maxBread);
    }

    public void BuyMaxBread(float price)
    {
        maxBread += breadStep;
        currentMoney -= price;

        OnBreadChanged?.Invoke(currentBread, maxBread);
        OnMoneyChanged?.Invoke(currentMoney);
    }

    public void BuySpeed(float price)
    {
        playerSpeed += speedStep;
        currentMoney -= price;

        OnSpeedChanged?.Invoke(playerSpeed);
        OnMoneyChanged?.Invoke(currentMoney);
    }

    public void BuyDrink(float price)
    {
        currentDrink += 1;
        currentMoney -= price;

        OnDrinkChanged?.Invoke(currentDrink, false);
        OnMoneyChanged?.Invoke(currentMoney);
    }

    public void UseDrink()
    {
        currentDrink -= 1;

        OnDrinkChanged?.Invoke(currentDrink, true);
    }

    public void BuyButter(float price)
    {
        currentButter += 1;
        currentMoney -= price;

        OnButterChanged?.Invoke(currentButter, false);
        OnMoneyChanged?.Invoke(currentMoney);
    }

    public void UseButter()
    {
        currentButter -= 1;

        OnButterChanged?.Invoke(currentDrink, true);
    }

}
