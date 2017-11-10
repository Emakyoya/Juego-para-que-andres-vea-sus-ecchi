using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorComp : GeneratorMaster
{
    

     void Start()
    {
        InvocarPrefab();
    }

    public override void InvocarPrefab()
    {
        InvokeRepeating("CreatePrefab", 0f, generatorTimer);


    }

    public override void CreatePrefab()
    {

        Instantiate(Prefab, transform.position, Quaternion.identity);


    }


}
