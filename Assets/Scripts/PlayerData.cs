using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerData : NetworkBehaviour {

    public static int NumberOfPlayers = 0;

    public string ID;

    public override void OnStartClient() {
        NumberOfPlayers++;
        ID = string.Format("Player{0}", NumberOfPlayers.ToString());
    }
}
