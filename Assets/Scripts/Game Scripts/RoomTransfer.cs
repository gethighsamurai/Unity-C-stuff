using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomTransfer : MonoBehaviour
{
    [SerializeField] private string roomToLoad;
    [SerializeField] private string playerTag;
    [SerializeField] private VectorValue playerPosInRoomValue;
    [SerializeField] private Vector2 playerTargetPosInRoom;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(playerTag) && !other.isTrigger)
        {
            playerPosInRoomValue.value = playerTargetPosInRoom;
            LoadRoom();
        }
    }


    void LoadRoom()
    {
        SceneManager.LoadScene(roomToLoad);
    }
}