using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //HARDCODED VALUES FOR TESTING

    int totalItems = 4;
    float[] agentOneValues = { 1f, 2f, 3f, 4f };
    float[] agentTwoValues = { 3f, 1f, 4f, 2f };

    public GameObject SquarePrefab;
    private List<GameObject>[] agents = new List<GameObject>[4];


    public GameObject ItemHolders;
    public Transform canvasTransform;

    void Start()
    {

        GameObject ItemHolder = Instantiate(ItemHolders, new Vector3(1000, 0, 0), Quaternion.identity);


        ItemHolder.transform.SetParent(canvasTransform, false);
        ItemHolder.transform.SetAsLastSibling();


        /*for (int i = 0; i < agents.Length; i++)
        {
            agents[i] = new List<GameObject>();
        }
        createItems();
        */
    }

    /*private void createItems()
    {
        for (int i = 0; i < agentOneValues.Length; i++)
        {
            GameObject squareA = Instantiate(SquarePrefab);
            squareA.transform.localScale = new Vector3(0.05f, agentOneValues[i] * 0.05f, 0f);
            squareA.transform.position += new Vector3(-8f, (-3.75f + (i * 2.5f)), 0f);

            GameObject squareB = Instantiate(SquarePrefab);
            squareB.transform.localScale = new Vector3(0.05f, agentTwoValues[i] * 0.05f, 0f);
            squareB.transform.position += new Vector3(-7f, (-3.75f + (i * 2.5f)), 0f);
        }
    }

    private void ClearAgentData(int agentIndex)
    {
        foreach (GameObject obj in agents[agentIndex])
        {
            Destroy(obj);
        }
        agents[agentIndex].Clear();
    }

    private void CreateAgentData(int agentIndex, string input, float xPos)
    {
        float[] values = System.Array.ConvertAll(input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries), float.Parse);
        float currentSize = -2f;

        foreach (float val in values)
        {
            GameObject square = Instantiate(SquarePrefab);
            Transform transform = square.GetComponent<Transform>();
            Vector3 newScale = transform.localScale;
            newScale.y *= val;
            transform.localScale = newScale;
            square.transform.position = new Vector3(xPos, currentSize + (val / 2), 0.0f);
            agents[agentIndex].Add(square);
            currentSize += val * 0.9f;
        }
    }

    public void GetInput1(string inputOne)
    {
        float[] indexes = System.Array.ConvertAll(inputOne.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries), float.Parse);

        ClearAgentData(0);
        CreateAgentData(0, inputOne, -4.35f);

        ClearAgentData(2);
        CreateAgentData(2, inputOne, 3.25f);
    }

    public void GetInput2(string inputTwo)
    {
        ClearAgentData(1);
        CreateAgentData(1, inputTwo, -0.85f);

        ClearAgentData(3);
        CreateAgentData(3, inputTwo, 6.75f);
    }
    */
}
