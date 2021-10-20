using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBollController : MonoBehaviour
{
    public GameObject[] Ammunation;

    // Start is called before the first frame update
    void Start()
    {

        //AmmunationSpawn();
        InvokeRepeating("AmmunationSpawn", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AmmunationSpawn()
    {
        int AmmunationIndex = Random.Range(0, Ammunation.Length);
        Instantiate(Ammunation[AmmunationIndex], transform);
    }

}
