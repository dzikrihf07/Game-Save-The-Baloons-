﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btPindahKeUIHasil : MonoBehaviour
{
    public GameObject UIHasil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void btPindah () {
        if (Input.GetMouseButtonDown(0))
            UIHasil.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }
}
