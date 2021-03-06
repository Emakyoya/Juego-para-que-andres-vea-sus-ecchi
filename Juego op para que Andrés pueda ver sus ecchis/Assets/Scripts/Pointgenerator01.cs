﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointgenerator01 : GeneratorMaster {


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
        x = 12;
        y = Random.Range(-3, 1);
        z = -1;
        randomPosition = new Vector3(x, y, z);
        Instantiate(Prefab, randomPosition, Quaternion.identity);
    }

}
