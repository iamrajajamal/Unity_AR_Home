﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    public GameObject theRoof;

    public GameObject[] secondFloor;

    public GameObject[] theLights;

    public GameObject directionalLight;

    public static HouseScript instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
