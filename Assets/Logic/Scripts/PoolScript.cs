using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript : MonoBehaviour
{
    public static PoolScript PSInstance;

    private List<GameObject> availableObjectpoolList;
    private List<GameObject> activepoolList;

    [SerializeField] private GameObject PoolPrefab;
    [SerializeField] private int StartingNumberofObjects;
    [SerializeField] private float despawnTimer;


    private void Awake()
    {
        if (PSInstance == null)
        {
            PSInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        availableObjectpoolList = new List<GameObject>();
        activepoolList = new List<GameObject>();
    }
    void Start()
    {
        CreateObject(StartingNumberofObjects);
    }


    private void CreateObject(int numberOfObjects)
    {
        GameObject TempObject;
        for (int i = 0; i < numberOfObjects; i++)
        {
            TempObject = Instantiate(PoolPrefab, Vector3.zero, Quaternion.identity,transform);
            TempObject.SetActive(false);
            availableObjectpoolList.Add(TempObject);
        }
    }

    public GameObject RequestObject()
    {
        if (availableObjectpoolList.Count != 0)
        {
            GameObject requestedObject = availableObjectpoolList[0];
            availableObjectpoolList.RemoveAt(0);
            activepoolList.Add(requestedObject);
            print(" Entra en request");
            requestedObject.SetActive(true);
            return requestedObject;
        }

        else
        {
            return null; 
        }
    }

    public void TurnOffObjects(GameObject objectToDespawn)
    {
        objectToDespawn.SetActive(false);
        availableObjectpoolList.Add(objectToDespawn);
        activepoolList.Remove(objectToDespawn);
    }
}
