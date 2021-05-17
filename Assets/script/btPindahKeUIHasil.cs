using System.Collections;
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
        UIHasil.gameObject.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
