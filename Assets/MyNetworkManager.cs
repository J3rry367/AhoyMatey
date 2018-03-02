using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
	
    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " starting host");
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " host started");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log(Time.timeSinceLevelLoad+ " Client start requested");
        //base.OnStartClient(myClient);
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client connected to IP: "+ conn.address);
        //base.OnClientConnect(conn);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
