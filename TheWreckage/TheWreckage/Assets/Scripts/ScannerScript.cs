using UnityEngine;

public class ScannerScript : MonoBehaviour
{
    public GameObject TerrainScannerPrefab;
    public float scanDuration = 10;
    public float scanSize = 500;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SpawnTerrainScanner();
        }
    }

    void SpawnTerrainScanner()
    {
        GameObject terrainScanner = Instantiate(TerrainScannerPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        ParticleSystem terrainScannerPS = terrainScanner.transform.GetChild(0).GetComponent<ParticleSystem>();

        if (terrainScannerPS != null)
        {
            var main = terrainScannerPS.main;
            main.startLifetime = scanDuration;
            main.startLifetime = scanSize;
        }
        else
        {
            Debug.Log("The first child doesn't have a particle system");
        }

        Destroy(terrainScanner, scanDuration+1);
    }
}
