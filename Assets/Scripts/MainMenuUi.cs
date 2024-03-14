using UnityEngine;
using UnityEngine.UI;
public class MainMenuUi : MonoBehaviour
{
    [SerializeField] private GameObject _lvlPanel;
    [SerializeField] private GameObject _buttonsPanel;
    [SerializeField] private GameObject _selectCarPanel;
    [SerializeField] private GameObject _dollaresPanel;

    public void OpenLvlPanel()
    {
        _dollaresPanel.SetActive(false);
        _selectCarPanel.SetActive(false);
        _lvlPanel.SetActive(true);
    }
    public void ClouseLvlPanel()
    {
        _dollaresPanel.SetActive(true);
        _lvlPanel.SetActive(false);
        _buttonsPanel.SetActive(true);
    }
    public void OpenSelectCarPanel()
    {
        _lvlPanel.SetActive(false);
        _buttonsPanel.SetActive(false);
        _selectCarPanel.SetActive(true);
    }
    public void ClouseSelectCarPanel()
    {
        _selectCarPanel.SetActive(false);
        _buttonsPanel.SetActive(true);
    }
}
