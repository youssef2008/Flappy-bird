using UnityEngine.SceneManagement;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour

{
    //Public variables are editable from the inspector
    public float minY;
    public float maxY;
    public float distance;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            //Choose random Y position
            float ObstacleY = Random.Range(minY, maxY);
            Vector3 newPos = new Vector3(transform.position.x + distance, ObstacleY, 0);
            collider.transform.position = newPos;
        }
    }
}