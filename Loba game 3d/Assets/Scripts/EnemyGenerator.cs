using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject Enemy; 
    float timeCounter = 0;
    public float GeneratingTime = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter + Time.deltaTime;

        if(timeCounter >= GeneratingTime)
        {
            Instantiate(Enemy, transform.position, transform. rotation);
            timeCounter = 0;
        }

    }
}
