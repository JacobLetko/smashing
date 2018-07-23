using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    GameObject obj;
    public List<GameObject> objs = new List<GameObject>();
    public float timer;
    Transform pos;

    private void Start()
    {
        pos = transform;
        Vector3 _pos = pos.position;
        _pos.x = 0;
        _pos.z = 0;
        _pos.y = 2;
        pos.position = _pos;
    }

    private void Update()
    {
        if(obj == null)
        {
            obj = Instantiate(objs[Random.Range(0, objs.Capacity)], pos);
        }
    }
}
