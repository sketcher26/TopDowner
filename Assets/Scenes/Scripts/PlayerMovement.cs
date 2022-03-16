using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public int speed;
    private Vector3 pointA;
    private Vector3 pointB;
    private bool isMoving = false;


    private void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.x -= Screen.width / 2;
        mousePos.y -= Screen.height / 2;
        if (Input.GetMouseButtonDown(0))
        {
            pointA = new Vector3(mousePos.x, player.position.y, mousePos.y);
        }
        if(Input.GetMouseButton(0))
        {
            
            isMoving = true;
            pointB = new Vector3(mousePos.x, player.position.y, mousePos.y);
        }
        else
        {
            isMoving = false;
        }
        
    }
    private void FixedUpdate()
    {
        if(isMoving)
        {


            Vector3 offset = pointB - pointA;
            Vector3 direction = Vector3.Normalize(offset);
            PlayerMove(direction);
            Debug.Log(direction);
        }
        
    }
    void PlayerMove(Vector3 direction)
    {
        var move = direction.normalized * speed * Time.fixedDeltaTime;
        var nextPosition = rb.position + move;
        rb.MovePosition(nextPosition);
    }
}
          
