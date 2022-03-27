using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movePlayerExpl : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameOver;
    public GameObject GameOverP;
    public GameObject GameOverP2;

    public bool strafeLeft = false;
    public bool strafeBack = false;
    public bool strafeRight = false;
    public bool strafeFront = false;
    public bool Healing = false;
    public bool ResW = false;   
    public int Distance = 10;

    
    public float LevelStamina = 1f;
    public float LevelHealth = 1f;

    public float Health = 300f;
    public float HealthTime = 0f;
    public float MHealth = 300f;
    public float LHealth = 0f;
    
    public float Stamina = 300f;
    public float MStamina = 300f;
    public float LStamina = 0f;

    public float Desert=0f;

    public int Ability_to_move = 0;
    public int Ability_to_R = 0;
    public int Ability_to_E = 0;

    public GameObject[] Chunk1Prefab;
    public GameObject[] Chunk1PrefabReady;
    public int Chunk1PrefabReadyA=0;
    public int Chunk1PrefabReadyALost=0;

    public Text Text; 
    public Text TextHealth; 
    public Text TextScore; 
    public Text TextScore2; 
    
    public Vector3 ChunkSize = new Vector3(1,1,1);

    public int ScorePoints = 0;

    public int Coord_X = 0; 
    public int Coord_Z = 0;

    public int Create = 0;

    public int[] Coord_X_All;
    public int[] Coord_Z_All;

    public int x;
    public int z;
    public int x1;
    public int z1;

    private void Start()
    {
        MStamina = MStamina + (100f * LevelStamina);
        MHealth = MHealth + (100f * LevelHealth);
        TextScore.text = "Score: " + ScorePoints;
    }

    private void OnTriggerEnter(Collider other){
        ScorePoints++;
        TextScore.text = "Score: " + ScorePoints;
        if (other.gameObject.tag == "Flower")
        {
            Ability_to_E=1;
        }
        if (other.gameObject.tag == "Desert")
        {
            Desert=100f;
        }
        if (other.gameObject.tag == "GameOver")
        {
            Health=-201f;
        }
        if (other.gameObject.tag == "Enemy")
        {
            Health=Health-40f;
            ScorePoints++;
            ScorePoints++;
            ScorePoints++;
            Stamina = 0f;
        }
        Ability_to_move=1;
        Ability_to_R=1;
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a")) {strafeLeft = true;}
        else {strafeLeft = false;}
        
        if (Input.GetKey("d")) {strafeRight = true;}
        else {strafeRight = false;}

        if (Input.GetKey("s")) {strafeBack = true;}
        else {strafeBack = false;}

        if (Input.GetKey("w")) {strafeFront = true;}
        else {strafeFront = false;}

        if (Input.GetKey("e")) {Healing = true;}
        else {Healing = false;}
        
        if (Input.GetKey("space")) {ResW = true;}
        else {ResW = false;}

        if (ResW == true && Ability_to_R==1)
            {
                Ability_to_R=0;
                transform.position  = new Vector3(10*Coord_X, 10, 10*Coord_Z);
                Health = Health -10f; LHealth=LHealth+10f;
                if (Stamina >= 200f+Desert)
                {
                    Stamina = Stamina-200f-Desert;
                    x = (Coord_X+1)*Distance;
                    z = (Coord_Z+1)*Distance;
                    x1 = (Coord_X-1)*Distance;
                    z1 = (Coord_Z-1)*Distance;
                    Desert=0f;
                    if (Chunk1PrefabReadyA>=24+Chunk1PrefabReadyALost)
                    {
                        Chunk1PrefabReadyA=0;
                        Chunk1PrefabReadyALost++;
                        if (Chunk1PrefabReadyALost>=10)
                            {
                                Chunk1PrefabReadyALost=10;
                            }
                    }
                    
                    Create = 1;
                    for (int i = 0; i <= 23+Chunk1PrefabReadyALost; i++){
                        if (Coord_X_All[i] == Coord_X*10 && Coord_Z_All[i] == z){
                            i = 26+Chunk1PrefabReadyALost;
                            Create = 0;
                        }
                    }
                    if (Create == 1)
                    {
                        Destroy(Chunk1PrefabReady[Chunk1PrefabReadyA]);
                        Chunk1PrefabReady[Chunk1PrefabReadyA] = Instantiate(Chunk1Prefab[UnityEngine.Random.Range(0, 6)], new Vector3(Coord_X*10, 0, z), Quaternion.identity);
                        Coord_X_All[Chunk1PrefabReadyA] = Coord_X*10; 
                        Coord_Z_All[Chunk1PrefabReadyA] = z;
                        Chunk1PrefabReadyA++;
                    }

                    Create = 1;
                    for (int i = 0; i <= 23+Chunk1PrefabReadyALost; i++){
                        if (Coord_X_All[i] == Coord_X*10 && Coord_Z_All[i] == z1){
                            i = 26+Chunk1PrefabReadyALost;
                            Create = 0;
                        }
                    }
                    if (Create == 1)
                    {
                        Destroy(Chunk1PrefabReady[Chunk1PrefabReadyA]);
                        Chunk1PrefabReady[Chunk1PrefabReadyA] = Instantiate(Chunk1Prefab[UnityEngine.Random.Range(0, 6)], new Vector3(Coord_X*10, 0, z1), Quaternion.identity);
                        Coord_X_All[Chunk1PrefabReadyA] = Coord_X*10; 
                        Coord_Z_All[Chunk1PrefabReadyA] = z1;
                        Chunk1PrefabReadyA++;
                    }

                    Create = 1;
                    for (int i = 0; i <= 23+Chunk1PrefabReadyALost; i++){
                        if (Coord_X_All[i] == x1 && Coord_Z_All[i] == Coord_Z*10){
                            i = 26+Chunk1PrefabReadyALost;
                            Create = 0;
                        }
                    }
                    if (Create == 1)
                    {
                        Destroy(Chunk1PrefabReady[Chunk1PrefabReadyA]);
                        Chunk1PrefabReady[Chunk1PrefabReadyA] = Instantiate(Chunk1Prefab[UnityEngine.Random.Range(0, 6)], new Vector3(x1, 0, Coord_Z*10), Quaternion.identity);
                        Coord_X_All[Chunk1PrefabReadyA] = x1; 
                        Coord_Z_All[Chunk1PrefabReadyA] = Coord_Z*10;
                        Chunk1PrefabReadyA++;
                    }

                    Create = 1;
                    for (int i = 0; i <= 23+Chunk1PrefabReadyALost; i++){
                        if (Coord_X_All[i] == x && Coord_Z_All[i] == Coord_Z*10){
                            i = 26+Chunk1PrefabReadyALost;
                            Create = 0;
                        }
                    }
                    if (Create == 1)
                    {
                        Destroy(Chunk1PrefabReady[Chunk1PrefabReadyA]);
                        Chunk1PrefabReady[Chunk1PrefabReadyA] = Instantiate(Chunk1Prefab[UnityEngine.Random.Range(0, 6)], new Vector3(x, 0, Coord_Z*10), Quaternion.identity);
                        Coord_X_All[Chunk1PrefabReadyA] = x; 
                        Coord_Z_All[Chunk1PrefabReadyA] = Coord_Z*10;
                        Chunk1PrefabReadyA++;
                    }
                }
                ResW = false;
            }

        if (Healing)        {if (Stamina >= 150f+Desert) if (Ability_to_E==1)    {{transform.position            =  new Vector3(10*Coord_X, 10, 10*Coord_Z); Stamina = Stamina-150f-Desert;Desert=0f; LStamina = LStamina +150f; Health = Health +100f; Ability_to_E=0;}}}
        
        if (strafeLeft)     {if (Stamina >= 150f+Desert) if (Ability_to_move==1) {{Coord_X--;transform.position  =  new Vector3(10*Coord_X, 10, 10*Coord_Z); Stamina = Stamina-150f-Desert;Desert=0f; Health = Health -10f; LHealth=LHealth+10f; LStamina = LStamina +150f; Ability_to_move=0;}}}

        if (strafeRight)    {if (Stamina >= 150f+Desert) if (Ability_to_move==1) {{Coord_X++;transform.position  =  new Vector3(10*Coord_X, 10, 10*Coord_Z); Stamina = Stamina-150f-Desert;Desert=0f; Health = Health -10f; LHealth=LHealth+10f; LStamina = LStamina +150f; Ability_to_move=0;}}}

        if (strafeBack)     {if (Stamina >= 150f+Desert) if (Ability_to_move==1) {{Coord_Z--;transform.position  =  new Vector3(10*Coord_X, 10, 10*Coord_Z); Stamina = Stamina-150f-Desert;Desert=0f; Health = Health -10f; LHealth=LHealth+10f; LStamina = LStamina +150f; Ability_to_move=0;}}} 

        if (strafeFront)    {if (Stamina >= 150f+Desert) if (Ability_to_move==1) {{Coord_Z++;transform.position  =  new Vector3(10*Coord_X, 10, 10*Coord_Z); Stamina = Stamina-150f-Desert;Desert=0f; Health = Health -10f; LHealth=LHealth+10f; LStamina = LStamina +150f; Ability_to_move=0;}}} 

        if (LHealth>=1000f)
        {   
            LevelHealth=LevelHealth+1f;
            if (LevelHealth>=10f)
            {
                LevelHealth=10f;
            }
            LHealth = 0f;
            MHealth = MHealth + (100f * LevelHealth);
        }
        if (LStamina>=20000f)
        {     
            LevelStamina = LevelStamina+1f;
            if (LevelStamina>=10f)
            {
                LevelStamina=10f;
            }
            LStamina = 0f;
            MStamina = MStamina + (100f * LevelStamina);
        }
        HealthTime = HealthTime + 1f;
        if (Desert>=99f)
            {
                HealthTime = HealthTime + 1f;
            }
        if (HealthTime>=50f)
        {
            Health = Health -1f;
            LHealth=LHealth+1f;
            HealthTime =0f;
        }

        if (Health >= MHealth)
        {
            Health = MHealth;
        }
        if (Stamina <= MStamina-1f) 
            {
                Stamina = Stamina+1f; 
            }
        else if (Stamina == MStamina)
            {
                Text.text = "Stamina: "+ MStamina +"/"+MStamina;
            }
        else if (Stamina >= MStamina)
        {
            Stamina = MStamina;
        }
        TextScore.text = "Score: " + ScorePoints;
        TextHealth.text = "Health: " + Health +"/"+MHealth;
        Text.text = "Stamina: " + Stamina +"/"+MStamina;

        if (Health <= 0f)
        {
            GameOver.SetActive(true);
            GameOverP.SetActive(false);
            GameOverP2.SetActive(false);
            TextScore2.text = "Score: " + ScorePoints;
            Time.timeScale = 0f;
        }
    }
}