using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public float aliveTime = 1;

    public GameObject HitEffect;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, aliveTime);
    }

    private void OnMouseDown()
    {
        Instantiate(HitEffect, this.gameObject.transform.position, Quaternion.identity);
    }
}
