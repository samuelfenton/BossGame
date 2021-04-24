using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBall_boss : MonoBehaviour
{

    [SerializeField] private GameObject full_Boss;
    [SerializeField] private float start_Health;
    private float current_health;

    // Start is called before the first frame update
    void Start()
    {
        //so when can change it later and increase health on dif levels
        start_Health = current_health; // * current_Level; //current_level from game manager
    }

    // Update is called once per frame
    //used for attack and upating health and of course when if it dies
    void Update()
    {
        int caseNumber = 1;
        float attack_chance = Random.value; ;

        if(current_health < (start_Health/2))
        {
            //increase attack animation speed
            //decrease time between attacks after animation
        }


        // reapeat this for all attacks and chance to hit
        if (attack_chance <= 0.1)
            caseNumber = 1;
        else if (attack_chance <= 0.3 && attack_chance > 0.1)
            caseNumber = 2;



        //this switch statement will call the other scipts with the attacks in them
        // make sure does not do another attack until after animation is played
        //add time after animation 
        switch(caseNumber)
        {
            case 1:
                //first attack type
                break;
            case 2:
                //second attack tpye
                break;
            //so on until attacks are full

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player_Weapon")
        {
            //current health - players weapon damage
        }
    }
}
