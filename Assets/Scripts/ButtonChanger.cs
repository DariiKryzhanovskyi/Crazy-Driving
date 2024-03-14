using TMPro;
using UnityEngine;

public class ButtonChanger : MonoBehaviour
{
    [SerializeField] private VehicleChooser _vehicleChooser;
    [SerializeField] private VehicleShop _vehicleShop;
    [SerializeField] private GameObject _buyButton;
    [SerializeField] private GameObject _selectButton;

    private TMP_Text _priceText;
    private Vehicle[] _vehicles;
    private int _index;

    private void Awake()
    {
        _priceText = _buyButton.GetComponentInChildren<TMP_Text>();

        Change();
    }
    private void OnEnable()
    {
        _vehicleChooser.OnVehicleSpawned += Change;
        _vehicleShop.OnVehicleBuyed += Change;
    }
    private void OnDisable()
    {
        _vehicleShop.OnVehicleBuyed -= Change;
        _vehicleChooser.OnVehicleSpawned -= Change;
    }
    private void Change() 
    {
        InitializationArray();
        _index = _vehicleChooser.CurrentIndex;
        bool examination = _vehicles[_index].IsBuyed;

        if (examination)
        {
            _buyButton.SetActive(false);
            _selectButton.SetActive(true);
        }
        else
        {
            _buyButton.SetActive(true);
            _selectButton.SetActive(false);
            _priceText.text = _vehicles[_index].Price.ToString() + "$";
        }
    }
    private void InitializationArray()
    {
        _vehicles = _vehicleChooser.GetAllVehicles();
    }
    public void Exit()
    {
        Change();
    }
}
