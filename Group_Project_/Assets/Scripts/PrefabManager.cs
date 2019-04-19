using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{

    //GameObject array storing the tracks
    public GameObject[] prefabManagers;

    //player position
    private Transform playerTransform;
    //spawns first track
    private float spawner = 0.0f;
    //Length between prefabs
    private float prefabLength = 40.0f;
    //Number of prefabs to be iterated through
    private int numOfPrefabs = 15; 
    //Zone around player
    private float safeZone = 25.0f;
    //List of track on play
    private List<GameObject> activeTrack;
    //Index of last track index
    private int lastPrefabIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        activeTrack = new List<GameObject>();
        //Gets the position of the character on the scene
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //Spawns first set of tracks
        for(int i = 0; i < numOfPrefabs; i++)
        {
            if(i < 2 )
            {
                SpawnTrack(0);
            }
            else
            {
            SpawnTrack();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Uses the player position to spawn tracks as needed
        if(playerTransform.position.z - safeZone > (spawner - numOfPrefabs * prefabLength))
        {
            SpawnTrack();
            DeleteTrack();
        }
    }

    private void SpawnTrack(int prefabIndex = -1)
    {
        GameObject go;
        if(prefabIndex == -1)
        {
        //Sets index 0 to be first spawned 
        go = Instantiate(prefabManagers[RandomPrefabIndex()]) as GameObject;
        }
        else
        {
            go = Instantiate(prefabManagers[prefabIndex]) as GameObject;
        }
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawner;
        spawner += prefabLength;
        activeTrack.Add(go);
    }

    private void DeleteTrack()
    {
        Destroy(activeTrack[0]);
        activeTrack.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if(prefabManagers.Length <= 1)
        {
            return 0;
        }

        int randomIndex = lastPrefabIndex;
        while(randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, prefabManagers.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
