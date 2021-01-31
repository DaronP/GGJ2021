using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpawn : MonoBehaviour
{

    public GameObject[] props;

    // Start is called before the first frame update
    void Start()
    {
        int rnd = Random.Range(0, props.Length + 2);
        if(rnd == (props.Length + 1))
        {
            Debug.Log("Simon aqui no va nada");
        }
        else
        {
            Instantiate(props[0], transform.position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
