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
            var aiObj = Instantiate(AtvPrefab, ai.transform.position, ai.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
