using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorEst : GeneratorMaster
{
    void Start()
    {
        InvocarPrefab();
    }

    public override void InvocarPrefab()
    {
        InvokeRepeating("CreatePrefab", 2f, generatorTimer);


    }



    public override void CreatePrefab()
    {
        Instantiate(Prefab, transform.position, Quaternion.identity);
    }
}
