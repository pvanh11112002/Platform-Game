using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingObject : Singleton<PoolingObject>
{
    private List<GameObject> knightPooled = new List<GameObject>();
    public GameObject knightPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < 10; j++)
        {
            GameObject objBot = Instantiate(knightPrefabs);
            objBot.SetActive(false);
            knightPooled.Add(objBot);
        }
    }
    public GameObject GetPooledObjectOfKnight()
    {
        for(int i = 0; i < knightPooled.Count; i++)
        {
            if (!knightPooled[i].activeInHierarchy)
            {
                return knightPooled[i];
            }            
        }
        return null;
    }
}
