using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    List<GameObject> chests = new List<GameObject>();
    public GameObject chestPrefab;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            CreateChest();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateChest()
    {
        var chest = Instantiate(chestPrefab, spawnPoint);
        chests.Add(chest);
    }
}
