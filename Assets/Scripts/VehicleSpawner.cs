using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameVehicles;

    private void Awake()
    {
        Spawn();
    }
    private void Spawn()
    {
        int vehicleIndex = VehicleChooser.IndexOfChoosedVehicle;

        if (_gameVehicles[vehicleIndex] != null)
            _gameVehicles[vehicleIndex].SetActive(true);
    }
}
