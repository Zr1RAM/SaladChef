using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager gameManager;
	// Use this for initialization
	void Awake ()
    {
		if(gameManager == null)
        {
            gameManager = this;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameCamera();
	}
    [SerializeField]
    Transform Player1, Player2;
    void GameCamera()
    {
        if(Player2 != null && Player1 != null)
        {
            Camera.main.transform.position = new Vector3((Player1.position.x + Player2.position.x) / 2, Camera.main.transform.position.y, (Player1.position.z + Player2.position.z) / 2);
        }
    }
}
