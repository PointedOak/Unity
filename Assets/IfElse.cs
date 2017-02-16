using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {
    private int grade = 27;
	// Use this for initialization
	void Start () {
        print("According to your grade, you are a:");
      
        //Determine financial status
        /* if (money >= 100)
        {
            print("You're rich!");
        }
        else if(money < 100)
        {   
            print("Time for the Ramen diet.");
        }
        */


        //Labeling people

        if (grade > 100)
        {
            print("Teacher's Pet.");
        }

        else if (grade < 100 && grade > 90)
        {
            print("Nerd.");
        }

        else if (grade < 90 && grade > 80)
        {
            print("Smart Guy/Gal.");
        }

        else if (grade < 80 && grade > 70)
        {
            print("A.I. (Average Intelligence)");
        }

        else if (grade < 70 && grade > 60)
        {
            print("Struggling");
        }
        else if (grade < 60)
        {
            print("Participation Ribbon");
        }
        else
        {
            print("You done broke the program...");
        }

    }
}
