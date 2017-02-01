using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField]
    private float m_movementSpeed = 0.7f;
    private Transform m_transform;
    public GameObject m_target;

	// Use this for initialization
	void Start () {
        m_transform = transform;
        m_target = GameObject.FindGameObjectWithTag("player1");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (m_target.transform.position.y < m_transform.position.y)
        {
            m_transform.Translate(m_transform.up * -m_movementSpeed * Time.deltaTime);
        }

        if (m_target.transform.position.y > m_transform.position.y)
        {
            m_transform.Translate(m_transform.up * m_movementSpeed * Time.deltaTime);
        }

        if (m_target.transform.position.x < m_transform.position.x - 0.5f)
        {
            m_transform.Translate(m_transform.right * -m_movementSpeed * Time.deltaTime);
            m_transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (m_target.transform.position.x > m_transform.position.x + 0.5f)
        {
            m_transform.Translate(m_transform.right * m_movementSpeed * Time.deltaTime);
            m_transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else
        {

        }

    }
}
