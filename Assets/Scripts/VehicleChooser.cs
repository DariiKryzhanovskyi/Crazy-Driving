using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class VehicleChooser : MonoBehaviour
{
    [SerializeField] private Vehicle[] _vehicles;
    [SerializeField] private Transform _spawn;

    private RCC_CarControllerV3 _currentVehicle;

    public static int IndexOfChoosedVehicle = 0;
    public UnityAction OnVehicleSpawned;
    public int CurrentIndex = 0;

    private void Start()
    {
        IndexOfChoosedVehicle = PlayerPrefs.GetInt("GameVehicle", 0);
        CurrentIndex = IndexOfChoosedVehicle;

        _currentVehicle = _vehicles[IndexOfChoosedVehicle].SpawnVehicle(_spawn.position, _spawn.rotation, false);
        OnVehicleSpawned?.Invoke();
    }
    public void NextVehicle()
    {
        CurrentIndex++;
        Spawn();
    }
    public void PreviusVehicle()
    {
        CurrentIndex--;
        Spawn();
    }
    public void ClouseSelectorVehicle()
    {
        CurrentIndex = IndexOfChoosedVehicle;
        Spawn();
    }
    private void Spawn()
    {
        if (CurrentIndex < 0)
            throw new ArgumentOutOfRangeException(nameof(CurrentIndex));

        if (CurrentIndex >= _vehicles.Length)
            throw new ArgumentOutOfRangeException(nameof(CurrentIndex));

        Destroy(_currentVehicle.gameObject);

        _currentVehicle = _vehicles[CurrentIndex].SpawnVehicle(_spawn.position, _spawn.rotation, false);
        OnVehicleSpawned?.Invoke();
    }
    public int GetVehiclesLenght()
    {
        return _vehicles.Length;
    }
    public Vehicle[] GetAllVehicles()
    {
        return _vehicles;
    }
    public void Choose()
    {
        IndexOfChoosedVehicle = CurrentIndex;

        PlayerPrefs.SetInt("GameVehicle", IndexOfChoosedVehicle);
    }
}
