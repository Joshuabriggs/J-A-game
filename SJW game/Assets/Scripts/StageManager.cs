using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {


    //GameObjects
    public GameObject m_enemyT;

    //Lists
    public List<EnemyController> m_enemies = new List<EnemyController>();
    public List<EnemyController> m_p1enemies = new List<EnemyController>();
    public List<EnemyController> m_p2enemies = new List<EnemyController>();
    public List<EnemyController> m_p3enemies = new List<EnemyController>();
    public List<EnemyController> m_p4enemies = new List<EnemyController>();

    //Variables
    int m_Ecount = 0;
    int m_Fcount = 0;
    int m_Hcount = 0;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < Gamestatemanager.instance.sManager.m_enemies.Count; i++)
        {
            if (Gamestatemanager.instance.sManager.m_enemies[i].m_target.tag == ("player1"))
            {
                m_p1enemies.Add(Gamestatemanager.instance.sManager.m_enemies[i]);
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

	
	}

    public void SpawnEnemy(Vector3 _pos)
    {
        GameObject newEnemy = (GameObject)Instantiate(m_enemyT, _pos, Quaternion.identity);
        m_enemies.Add(newEnemy.GetComponent<EnemyController>());
    }

    void BehviourAllocation(List<EnemyController> _list)
    {
        for(int i = 0; i< _list.Count; i++)
        {
            switch(_list[i].m_currentBehaviour)
            {
                case 1:
                    m_Ecount++;
                    break;

                case 2:
                    m_Fcount++;
                    break;

                case 3:
                    m_Hcount++;
                    break;
            }
        }
       
    }
}
