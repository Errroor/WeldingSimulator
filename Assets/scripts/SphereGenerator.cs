using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    public GameObject spherePrefab;
    public float spawnInterval = 0.3f; // Интервал между спауном сфер
    private float lastSpawnTime;

    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            if (Time.time - lastSpawnTime > spawnInterval)
            {
                GenerateSphere();
                lastSpawnTime = Time.time;
            }
        }
    }

    void GenerateSphere()
    {
        Vector3 spawnPosition = transform.position + transform.forward * 2; // Смещаем позицию спауна вперед от объекта
        Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
    }
}
