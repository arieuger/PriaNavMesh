using UnityEngine;
using UnityEngine.AI;

public class ClickTarget : MonoBehaviour
{
    private NavMeshAgent agent;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Debug.Log("Hola");
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000)) {
                agent.isStopped = false;
                agent.destination = hit.point;
                Debug.Log("Qué tal");
            }
        }
        if (Input.GetMouseButtonDown(1)) {
            agent.isStopped = true;
        }
    }
}
