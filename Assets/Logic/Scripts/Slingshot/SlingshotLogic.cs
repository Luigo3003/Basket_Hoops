using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlingshotLogic : MonoBehaviour
{
    public float power = 10f;
    public Transform PlayerPos;
    private PeegleInputs inputActions;
    private PoolScript BallPool;
    public GameObject BallPoolGO;
    public GameObject BallPrefab;

    TrajectoryLine tl;

    public float minPower;
    public float maxPower;

    Camera cam;

    //Vector2 force;
    Vector3 startPoint;
    Vector3 currentPoint;
    Vector3 endPoint;

    private void Awake()
    {
        inputActions = new PeegleInputs();
        BallPool = BallPoolGO.GetComponent<PoolScript>();
        
    }
    void Start()
    {
        tl = GetComponent<TrajectoryLine>();
        tl.enabled = false;
        cam = Camera.main;
        inputActions.Enable();
        inputActions.MouseInput.clickDown.performed += leftClickMouseDown;
        inputActions.MouseInput.clickDown.canceled += leftClickMouseUp;
    }
    void Update()
    {
        if (tl.enabled == true)
        {
            currentPoint = cam.ScreenToWorldPoint(inputActions.MouseInput.ClickDownPos.ReadValue<Vector2>());
            tl.RenderLine(startPoint, currentPoint);
        }
        
    }

    void leftClickMouseDown(InputAction.CallbackContext ctx)
    {
        startPoint = cam.ScreenToWorldPoint(inputActions.MouseInput.ClickDownPos.ReadValue<Vector2>());
        startPoint.z = 15f;
        tl.enabled = true;
        BallPrefab = BallPool.RequestObject();
        BallPrefab.transform.position = PlayerPos.position;

    }

    void leftClickMouseUp(InputAction.CallbackContext ctx) {
        endPoint = cam.ScreenToWorldPoint(inputActions.MouseInput.ClickDownPos.ReadValue<Vector2>());
        endPoint.z = 15f;
        tl.enabled = false;
        tl.EndLine();
        calculateForce();
        BallPrefab.GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    private void calculateForce()
    {
        Vector2 direction = startPoint-endPoint;
        float totalForce = direction.magnitude;
        direction = direction.normalized;
        if (totalForce >= maxPower)
        {
            totalForce = maxPower;
        }
        else if (totalForce <= minPower) {
            totalForce = minPower;
        }

        BallPrefab.GetComponent<Rigidbody2D>().AddForce(direction * totalForce, ForceMode2D.Impulse);

    }
}
