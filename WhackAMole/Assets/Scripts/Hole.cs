using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    int minInterval = 2;
    int maxInterval = 10;

    public GameObject Mole;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", Random.Range(minInterval, maxInterval), Random.Range(minInterval, maxInterval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(Mole, this.gameObject.transform.position, Quaternion.identity);
    }
}
