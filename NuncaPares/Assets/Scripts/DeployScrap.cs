using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployScrap : MonoBehaviour
{
    public GameObject nutPrefab;
    public GameObject gearPrefab;
    public GameObject battery;
    public float respawnTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(scrapWave());
    }

    private void spawnScrap()
    {
        nutPrefab = Instantiate(nutPrefab) as GameObject;
        gearPrefab = Instantiate(gearPrefab) as GameObject;
        battery = Instantiate(battery) as GameObject;
        nutPrefab.transform.position = new Vector2(Random.Range(-12, 12), 8);
        gearPrefab.transform.position = new Vector2(Random.Range(-12, 12), 15);
        battery.transform.position = new Vector2(Random.Range(-12, 12), 3);
    }

    IEnumerator scrapWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnScrap();
        }
    }
}
