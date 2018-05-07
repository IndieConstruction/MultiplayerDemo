using UnityEngine;
using UnityEngine.Networking;

public class GameManager : NetworkBehaviour {

    public Ball BallPrefab;

    public override void OnStartServer() {

    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            CmdSpawnBall();
        }
    }

    [Command]
    private void CmdSpawnBall() {
        NetworkServer.Spawn(Instantiate(BallPrefab.gameObject));
    }
}
