using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start1()
    {
        this.transform.position = GameManager1.instance.GetLastPos();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
