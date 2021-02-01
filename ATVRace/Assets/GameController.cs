using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject AtvPrefab;
    public GameObject[] AIinitialPos;
    // Start is called before the first frame update
    void Start()
    {
        AIinitialPos = GameObject.FindGameObjectsWithTag("AIinitialPos");
        foreach (var ai in AIinitialPos)
        {
            float maxSpeed = Random.Range(200, 300);
            float engineRand = Random.Range(3000, 4000);
            var aiObj = Instantiate(AtvPrefab, ai.transform.position, ai.transform.rotation);
            aiObj.GetComponent<SAICSmartAICar>().engineTorque = engineRand;
            aiObj.GetComponent<SAICSmartAICar>().maximumSpeed = maxSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
