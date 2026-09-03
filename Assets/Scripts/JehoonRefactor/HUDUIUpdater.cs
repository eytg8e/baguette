using UnityEngine;

public class HUDUIUpdater : MonoBehaviour
{
    private PlayerState playerState;
    // HUD UI 관련 요소들을 모두 가지고 있다. State에서 만든 이벤트를 구독해서 UI를 업데이트한다.
    private void OnEnable()
    {
        playerState.OnHealthChanged += UpdateHealthUI;
        playerState.OnBreadChanged += UpdateBreadUI;
        playerState.OnMoneyChanged += UpdateMoneyUI;
        playerState.OnDrinkChanged += UpdateDrinkUI;
        playerState.OnButterChanged += UpdateButterUI;
    }

    private void OnDisable()
    {
        playerState.OnHealthChanged -= UpdateHealthUI;
        playerState.OnBreadChanged -= UpdateBreadUI;
        playerState.OnMoneyChanged -= UpdateMoneyUI;
        playerState.OnDrinkChanged -= UpdateDrinkUI;
        playerState.OnButterChanged -= UpdateButterUI;
    }

    private void UpdateHealthUI(int currentHP, int maxHP)
    {

    }

    private void UpdateBreadUI(int currentBread, int maxBread)
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
