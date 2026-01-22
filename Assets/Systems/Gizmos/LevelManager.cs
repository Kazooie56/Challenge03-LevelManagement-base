using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level01;
    public GameObject level02;

    private GameObject currentActiveLevel;
    private GameObject levelManager;
    private Transform spawnLocation;

    private GameObject Player;

    public void LevelChange()
    {
        level01.SetActive(false);
        level02.SetActive(true);
    }
}
