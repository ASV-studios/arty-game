using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerConnection : NetworkBehaviour
{

    public GameObject playerUnitPrefab;
    GameObject myPlayerUnit;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        // check if this belongs to the player
        if (isLocalPlayer == false)
        {
            return;
        }

        CmdSpawnPlayerUnit();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Command]
    void CmdSpawnPlayerUnit()
    {
        GameObject unit = Instantiate(playerUnitPrefab);
        myPlayerUnit = unit;
        NetworkServer.SpawnWithClientAuthority(unit, connectionToClient);
    }

    [Command]
    void CmdMove()
    {
        player.Move();
    }
}
