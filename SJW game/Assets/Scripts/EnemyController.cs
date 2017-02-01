using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


    //Components
    private EnemyFlank m_flank;
    private EnemyMovement m_move;
    private EnemyPunch m_punch;

    //Objects
    public GameObject m_target;

    //Variables
    public int m_currentBehaviour;

   

    // Use this for initialization
    void Start () {

        m_currentBehaviour = 3;
        m_flank = GetComponent<EnemyFlank>();
        m_move = GetComponent<EnemyMovement>();
        m_punch = GetComponent<EnemyPunch>();     
		
	}
	
	// Update is called once per frame
	void Update () {
		
        
	}

    public void Engage()
    {
        m_currentBehaviour = 1;
    }

    public void Flank()
    {
        m_currentBehaviour = 2;
    }

    public void Hold()
    {
        m_currentBehaviour = 3;
    }
}
