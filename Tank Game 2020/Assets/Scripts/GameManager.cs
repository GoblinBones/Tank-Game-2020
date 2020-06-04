using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject player;

    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        //deletes the instance if there is already one created
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        //Does not delete the game manager when scene change
        DontDestroyOnLoad(this.gameObject);
    }
}
