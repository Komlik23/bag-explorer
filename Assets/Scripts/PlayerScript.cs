using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { PREVIEW, GAME, PAUSE };

public class PlayerScript : MonoBehaviour {

    public float cameraSpeed = 0.1f;
    public GameState state = GameState.GAME;

    Vector3 start = new Vector3(0, 1, -6);
    Vector3 destination = new Vector3(0, 2, -1);

    void Start () {
		if (this.state == GameState.GAME)
        {
            this.MoveCameraToGamePosition();
        }
	}
	
	void Update () {
        
    }

    void MoveCameraToGamePosition()
    {
        transform.Translate(this.destination);
        transform.Rotate(45, 0, 0);
    }
}
