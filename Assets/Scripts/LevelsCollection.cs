using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New LevelsCollection", menuName = "ScriptableObjects/LevelsCollection")]
public class LevelsCollection : ScriptableObject
{
    [SerializeField] private int _myLevelsCollection = 1;

    public UnityAction OnCollectionsChanged;
    public void AddLevel()
    {
        _myLevelsCollection++;
        OnCollectionsChanged?.Invoke();
    }
    public int GetCollection()
    {
        return _myLevelsCollection;
    }
    public void SetCollection(int number)
    {
        _myLevelsCollection = number;
    }
}
