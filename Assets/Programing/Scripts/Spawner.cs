using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public List<GameObject> objs = new List<GameObject>();
    public float timer;
    float _timer;
    Vector3 pos;
    Vector3 zero;

    private void Start()
    {
        zero = Vector3.zero;
        pos = transform.position;
    }

    private void Update()
    {
        _timer = _timer - Time.deltaTime;
        if(obj == null && _timer < 0)
        {
            //obj = Instantiate(objs[Random.Range(0, objs.Capacity)], pos, Quaternion.);
            _timer = timer;
            obj = Instantiate(objs[Random.Range(0, objs.Capacity)]);
            obj.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }
    }
}
