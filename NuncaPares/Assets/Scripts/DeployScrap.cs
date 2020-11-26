using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployScrap : MonoBehaviour
{
    public GameObject nutPrefab;
    public GameObject gearPrefab;
    public float respawnTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(scrapWave());
    }

    private void spawnScrap()
    {
        GameObject nut = Instantiate(nutPrefab) as GameObject;
        GameObject gear = Instantiate(gearPrefab) as GameObject;
        nut.transform.position = new Vector2(Random.Range(-12, 12), 8);
        gear.transform.position = new Vector2(Random.Range(-12, 12), 15);
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
