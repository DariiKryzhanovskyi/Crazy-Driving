using UnityEngine;

public class ArrowIconController : MonoBehaviour
{
    [SerializeField] private GameObject _leftArrow;
    [SerializeField] private GameObject _rightArrow;
    [SerializeField] private VehicleChooser _vehicleChooser;

    private void OnEnable()
    {
        _vehicleChooser.OnVehicleSpawned += Check;
    }
    private void OnDisable()
    {
        _vehicleChooser.OnVehicleSpawned -= Check;
    }
    private void Check()
    {
        int currentIndex = _vehicleChooser.CurrentIndex;

        if(currentIndex == 0)
        {
            _leftArrow.SetActive(false);
        }
        else if (currentIndex > 0)
        {
            _leftArrow.SetActive(true);
        }
        if (currentIndex == _vehicleChooser.GetVehiclesLenght() - 1 )
        {
            _rightArrow.SetActive(false);
        }
        else if (currentIndex < _vehicleChooser.GetVehiclesLenght() - 1)
        {
            _rightArrow.SetActive(true);
        }
    }
}