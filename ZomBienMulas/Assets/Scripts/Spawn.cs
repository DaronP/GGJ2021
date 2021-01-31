using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {
        int rnd = Random.Range(0, objs.Length);
        GameObject instancia = (GameObject)Instantiate(objs[rnd], transform.position, Quaternion.identity);
        instancia.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
