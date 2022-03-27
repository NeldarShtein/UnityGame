using UnityEngine;

public class pc1 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = player.position+offset;
    }
}

