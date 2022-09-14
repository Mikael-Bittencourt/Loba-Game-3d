using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherPlayerThings : MonoBehaviour
{

    public GameObject GameOverText;
    public bool PlayerAlive = true;
    public bool mouseLookEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(PlayerAlive == false)
        {
            if(Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Endless mode");
            }
        }
    }
    
}
