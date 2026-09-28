using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
public class AgentController : MonoBehaviour
{

    NavMeshAgent agent; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputSystem.actions.FindAction("Click").IsPressed())
        {
            Vector2 mousePos = InputSystem.actions.FindAction("Point").ReadValue < Vector2>();//return a point on the screenfrom a mouse
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                agent.SetDestination(hit.point);
            }
        }
    }
}
