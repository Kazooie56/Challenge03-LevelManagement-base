using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    public GameObject levelToActivate;
    public Transform spawnLocation;

    private void Start()
    {
        levelManager = FindAnyObjectByType<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("trigger is triggered");

            // tell the level manager to change levels

            levelManager.LevelChange(levelToActivate, spawnLocation);
        }
    }
}
