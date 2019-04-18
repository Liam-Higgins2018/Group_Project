using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{

    public GameObject[] prefabManagers;

    private Transform playerTransform;
    private float spawner = 0.0f;
    private float prefabLength = 30.0f;
    private int numOfPrefabs = 15; 

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < numOfPrefabs; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > (spawner - numOfPrefabs * prefabLength))
        {
            SpawnTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(prefabManagers[0] as GameObject);
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawner;
        spawner += prefabLength;
    }
}
