using UnityEngine;

[CreateAssetMenu(fileName = "New Vehicle", menuName = "ScriptableObjects/Vehicle")]
public class Vehicle : ScriptableObject
{
    [SerializeField] private RCC_CarControllerV3 _vehiclePrefab;
    [SerializeField] private float _price = 50f;

    public bool IsBuyed = true;
    public float Price => _price;

    public RCC_CarControllerV3 SpawnVehicle(Vector3 position, Quaternion rotation, bool isControllable)
    {
        return RCC.SpawnRCC(_vehiclePrefab, position, rotation, true, isControllable, false);
    }
    public GameObject GetModel()
    {
        return _vehiclePrefab.gameObject;
    }
}
