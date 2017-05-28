using SocketIO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviour {

    public SocketIOComponent socket;

	void Start () {
        StartCoroutine(ConnectToServer());
        socket.On("USER_CONNECTED", OnUserConnected);
        socket.On("PLAY", OnUserPlay);
	}

    IEnumerator ConnectToServer()
    {
        yield return new WaitForSeconds(0.5f);

        socket.Emit("USER_CONNECT");

        yield return new WaitForSeconds(1f);

        Dictionary<string, string> data = new Dictionary<string, string>();
        data["name"] = "Ali Osman";
        Vector3 position = new Vector3(0, 0, 0);
        data["position"] = position.x + "," + position.y + "," + position.z;
        socket.Emit("PLAY", new JSONObject(data));
    }
	
	private void OnUserConnected(SocketIOEvent e)
    {
        Debug.Log("Someone connected to " + socket.url + " as " + e.data.GetField("name") + " at " + e.data.GetField("position"));
    }

    private void OnUserPlay(SocketIOEvent e)
    {
        Debug.Log("Player is ready to play. Everyone is going to know that..");
    }
}
