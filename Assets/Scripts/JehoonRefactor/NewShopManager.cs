using UnityEngine;

public class NewShopManager : MonoBehaviour
{
    private PlayerState playerState;
    private ShopState shopState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuyMaxHealth()
    {
        float price = shopState.MaxHealthLevelUpPrice();
        if (playerState.CurrentMoney >= price)
        {
            playerState.BuyMaxHealth(price);
            shopState.MaxHealthLevelUp();
        }
    }

    public void BuyMaxBread()
    {
        float price = shopState.MaxBreadLevelUpPrice();
        if (playerState.CurrentMoney >= price)
        {
            playerState.BuyMaxBread(price);
            shopState.MaxBreadLevelUp();
        }
    }

    public void BuySpeed()
    {
        float price = shopState.SpeedLevelUpPrice();
        if (playerState.CurrentMoney >= price)
        {
            playerState.BuySpeed(price);
            shopState.SpeedLevelUp();
        }
    }

    public void BuyDrink()
    {
        float price = shopState.DrinkPrice;
        if (playerState.CurrentMoney >= price)
        {
            playerState.BuyDrink(price);
        }
    }

    public void BuyButter()
    {
        float price = shopState.ButterPrice;
        if (playerState.CurrentMoney >= price)
        {
            playerState.BuyButter(price);
        }
    }

}
