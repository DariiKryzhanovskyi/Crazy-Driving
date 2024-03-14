using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public void LoadGameScene(int lvlIndex)
    {
        SceneChanger.LoadScene(lvlIndex);
    }
}
