using UnityEngine;

public class pc : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 DistanceLVC;   
    public int DistanceLV;

    private void Start()
    {
        DistanceLV = PlayerPrefs.GetInt("DistanceLV");
        DistanceLVC[1] = DistanceLV;
        DistanceLVC[2] = -DistanceLV;
    }
    void Update()
    {
        transform.position = player.position+offset+DistanceLVC;
    }
}

