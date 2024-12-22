using UnityEngine;
using Mirror;

public class CreateRoomUI : MonoBehaviour
{




    public void CreateRoom()
    {
        var manager = RoomManager.singleton;
        // 방 설정 작업 처리

        manager.StartHost();
    }
}
