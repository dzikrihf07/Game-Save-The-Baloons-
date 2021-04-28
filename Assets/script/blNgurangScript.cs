using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blNgurangScript : MonoBehaviour
{
    public GameObject bl1, bl2, bl3;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        bl1.gameObject.SetActive(true);
        bl2.gameObject.SetActive(true);
        bl3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health) {
            case 3:
                bl1.gameObject.SetActive(true);
                bl2.gameObject.SetActive(true);
                bl3.gameObject.SetActive(true);
            break;
            case 2:
                bl1.gameObject.SetActive(true);
                bl2.gameObject.SetActive(true);
                bl3.gameObject.SetActive(false);
            break;
            case 1:
                bl1.gameObject.SetActive(true);
                bl2.gameObject.SetActive(false);
                bl3.gameObject.SetActive(false);
            break;
            case 0:
                bl1.gameObject.SetActive(false);
                bl2.gameObject.SetActive(false);
                bl3.gameObject.SetActive(false);
            break;
        }
    }
}
