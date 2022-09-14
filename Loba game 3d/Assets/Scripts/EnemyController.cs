using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyController : MonoBehaviour
{
    public GameObject Player;
    public float Speed = 5;
     
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        Vector3 direction = Player.transform.position - transform.position;

        Quaternion newRotation = Quaternion.LookRotation(direction);
        GetComponent<Rigidbody>().MoveRotation(newRotation);

        if(distance > 1.5)
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direction.normalized * Speed * Time.deltaTime);

            GetComponent<Animator>().SetBool("Attacking", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Attacking", true);
        }
    }

    void AttackingPlayer()
    {
        Time.timeScale = 0;
        Player.GetComponent<OtherPlayerThings>().GameOverText.SetActive(true);
        Player.GetComponent<OtherPlayerThings>().PlayerAlive = false;
    }
}
