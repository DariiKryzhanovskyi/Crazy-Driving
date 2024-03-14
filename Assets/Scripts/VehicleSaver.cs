using System;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleSaver : MonoBehaviour
{
    [SerializeField] private VehicleChooser _chooser;
    [SerializeField] private VehicleShop _shop;

    private Vehicle[] _vehicles;

    private void OnEnable()
    {
        _shop.OnVehicleBuyed += SaveVehicles;
    }
    private void OnDisable()
    {
        _shop.OnVehicleBuyed -= SaveVehicles;
    }
    private void Awake()
    {
        _vehicles = _chooser.GetAllVehicles();

        GetState();
    }
    private void GetState()
    {
        for (int i = 0; i < _vehicles.Length; i++)
        {
            bool state = Convert.ToBoolean(PlayerPrefs.GetInt("Vehicle" + i, 0));
            _vehicles[i].IsBuyed = state;
        }
    }
    private void SaveVehicles()
    {
        for (int i = 0; i < _vehicles.Length; i++)
        {
            int valueSave = Convert.ToInt32(_vehicles[i].IsBuyed);
            PlayerPrefs.SetInt("Vehicle" + i, valueSave);
            PlayerPrefs.Save();
        }
    }
}
