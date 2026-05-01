using UnityEngine;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "New WaveConfig")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] GameObject[] enemyPrefab;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float enemyMoveSpeed = 4.5f;

     public int GetEnemyCount()
    {
        return enemyPrefab.Length;
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefab[index];
    }
    
    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public float GetEnemyMoveSpeed()
    {
        return enemyMoveSpeed;
    }

    public Transform[] GetWaypoints()
    {
        Transform[] waypoints = new Transform[pathPrefab.childCount];

        for (int i = 0; i < pathPrefab.childCount; i++)
        {
            waypoints[i] = pathPrefab.GetChild(i);
        }

        return waypoints;
    }
}
