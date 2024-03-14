using UnityEngine;
using UnityEngine.Events;

public class VehicleShop : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private VehicleChooser _vehicleChooser;

    public UnityAction OnVehicleBuyed;

    private Vehicle[] _vehicles;
    public void Buy()
    {
        InitializationVehicles();

        int index = _vehicleChooser.CurrentIndex;
        float price = _vehicles[index].Price;
        bool isSpend;

        isSpend = _wallet.TrySpendMoney(price);

        if (isSpend)
        {
            GiveVehicle();
            OnVehicleBuyed?.Invoke();
        }
    }
    private void InitializationVehicles()
    {
        _vehicles = _vehicleChooser.GetAllVehicles();
    }
    private void GiveVehicle()
    {
        _vehicles[_vehicleChooser.CurrentIndex].IsBuyed = true;
    }
}
