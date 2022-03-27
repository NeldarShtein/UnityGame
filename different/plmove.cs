using UnityEngine;

public class plmove : MonoBehaviour
{
    public int SpeedLV;
    public int JumpLV;

    public Rigidbody rb;

    public float runSpeed = 1f;
    public float strafeSpeed= 1f;
    public float jumpForce = 350f;
    float timer = 2f;
    public float Mtimer = 200f;

    public bool strafeLeft = false;
    public bool strafeBack = false;
    public bool strafeRight = false;
    public bool strafeFront = false;
    public bool dojump = false;
    
    private void Start()
    {
        SpeedLV = PlayerPrefs.GetInt("SpeedLV");
        JumpLV = PlayerPrefs.GetInt("JumpLV");
        PlayerPrefs.SetFloat("runSpeed", 30f);
        PlayerPrefs.SetFloat("strafeSpeed", 15f);
        PlayerPrefs.SetFloat("jumpForce", 350f);
    }

    private void OnTriggerEnter(Collider other){
        other.gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("space")) {if (timer == 2f) {dojump = true;}}
        
        if (Input.GetKey("a")) {strafeLeft = true;}
        else {strafeLeft = false;}
        
        if (Input.GetKey("d")) {strafeRight = true;}
        else {strafeRight = false;}

        if (Input.GetKey("s")) {strafeBack = true;}
        else {strafeBack = false;}

        if (Input.GetKey("w")) {strafeFront = true;}
        else {strafeFront = false;}
        
        if (strafeLeft) {if (timer == 2f) {rb.AddForce(-(strafeSpeed+(SpeedLV+3f)) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);}}

        if (strafeRight) {if (timer == 2f) {rb.AddForce((strafeSpeed+(SpeedLV+3f)) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);}}

        if (strafeBack) {if (timer == 2f) {rb.AddForce(0, 0, -(strafeSpeed+(SpeedLV+3f)) * Time.deltaTime, ForceMode.VelocityChange);}}

        if (strafeFront) {if (timer == 2f) {rb.AddForce(0, 0, (strafeSpeed+(SpeedLV+3f)) * Time.deltaTime, ForceMode.VelocityChange);}}

        if (dojump) {rb.AddForce(Vector3.up * (jumpForce+(50f*JumpLV+2f)), ForceMode.Impulse); dojump = false; timer = timer+1f;}

        if (timer >= 3f) {timer = timer+1f; 
        if (timer >= Mtimer) {timer = 2f;} } }
    
}
