using UnityEngine;
using Mirror;

public class CreateRoomUI : MonoBehaviour
{




    public void CreateRoom()
    {
        var manager = RoomManager.singleton;
        // �� ���� �۾� ó��

        manager.StartHost();
    }
}
