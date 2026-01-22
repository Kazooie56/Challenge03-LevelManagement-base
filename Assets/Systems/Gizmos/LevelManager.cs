using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level01;
    public GameObject level02;
    public GameObject level03;
    public GameObject level04;

    [SerializeField]
    private GameObject currentLevel;
    private GameObject levelManager;
    private Transform spawnLocation;

    private GameObject Player;

    public void Start()
    {
        // someone elaborate on this to me later
        Player = ServiceHub.Instance.playerController.gameObject;
        currentLevel = level01;
    }

    public void LevelChange(GameObject targetLevel, Transform spawnLocation)
    {
        currentLevel.SetActive(false);
        targetLevel.SetActive(true);
        currentLevel = targetLevel;
        Player.transform.position = spawnLocation.position;
    }
}
