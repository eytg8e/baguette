using UnityEngine;

public class ShopUIUpdater : MonoBehaviour
{
    private PlayerState playerState;
    private ShopState shopState;
    // 상점 UI 관련 요소들을 모두 가지고 있다. ShopState에서 만든 이벤트와 PlayerState의 현재 돈, 소모품 관련 이벤트를 구독해서 UI를 업데이트한다.
    private void OnEnable()
    {
        shopState.OnMaxHealthLevelChanged += UpdateMaxHealthUI;
        shopState.OnMaxBreadLevelChanged += UpdateMaxBreadUI;
        playerState.OnMoneyChanged += UpdateMoneyUI;
        playerState.OnDrinkChanged += UpdateDrinkUI;
        playerState.OnButterChanged += UpdateButterUI;
    }

    private void OnDisable()
    {
        shopState.OnMaxHealthLevelChanged -= UpdateMaxHealthUI;
        shopState.OnMaxBreadLevelChanged -= UpdateMaxBreadUI;
        playerState.OnMoneyChanged -= UpdateMoneyUI;
        playerState.OnDrinkChanged -= UpdateDrinkUI;
        playerState.OnButterChanged -= UpdateButterUI;
    }

    private void UpdateMaxHealthUI(int maxHealthLevel, float maxHealthBasePrice, float maxHealthPriceStep)
    {

    }

    private void UpdateMaxBreadUI(int maxBreadLevel, float maxBreadBasePrice, float maxBreadPriceStep)
    {

    }

    private void UpdateMoneyUI(float currentMoney)
    {

    }

    private void UpdateDrinkUI(int currentDrink, bool isEnchanted)
    {

    }

    private void UpdateButterUI(int currentButter, bool isEnchanted)
    {

    }

}
