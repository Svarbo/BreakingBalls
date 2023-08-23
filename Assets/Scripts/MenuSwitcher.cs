using UnityEngine;
using UnityEngine.UI;

public class MenuSwitcher : MonoBehaviour
{
    [SerializeField] private Image _mainMenu;
    [SerializeField] private Image _levelMenu;

    public void EnableLevelMenu()
    {
        _levelMenu.gameObject.SetActive(true);
        _mainMenu.gameObject.SetActive(false);
    }

    public void EnableMainMenu()
    {
        _mainMenu.gameObject.SetActive(true);
        _levelMenu.gameObject.SetActive(false);
    }
}
