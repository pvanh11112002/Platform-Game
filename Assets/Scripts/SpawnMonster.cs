using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    [SerializeField] Transform[] gateToSpawnMons;
    [SerializeField] float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 5)
        {
            for (int i = 0; i < gateToSpawnMons.Length; i++)
            {
                GameObject knight = PoolingObject.Instance.GetPooledObjectOfKnight();
                if (knight != null)
                {
                    knight.transform.position = gateToSpawnMons[i].position;
                    //knight.transform.rotation = knight.rotation;
                    knight.SetActive(true);
                }
            }
            elapsedTime = 0;
        }    
    }
}
