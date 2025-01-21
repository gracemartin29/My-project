using UnityEngine;

public class spawnAnimal : MonoBehaviour
{
    public GameObject myPrefab;
    float timeStamp;
    float spawnRate = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeStamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        if (elapsedTime > timeStamp + spawnRate){
            Instantiate(myPrefab, new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f)), Quaternion.AngleAxis(Random.Range(0, 360), transform.up));
            timeStamp = elapsedTime;
        }
    }
}
