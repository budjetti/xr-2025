using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private List<Transform> nodes;
    [SerializeField] private GameObject player;
    [SerializeField] private int current = 0;

    public InputActionReference action;
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            current++;
            if(current > nodes.Count){
                current = 0;
            }

            player.transform.position = nodes[current].position;
        };
    }
}
