using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController _instance;
    public PlayerController player;
    public NetworkController network;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
    }

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        network = GameObject.Find("NetworkManager").GetComponent<NetworkController>();
    }

}
