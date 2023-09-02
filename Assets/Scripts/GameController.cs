using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject SquarePrefab;

    private float[] agentOneAVals; //values
    private ArrayList agentA1 = new ArrayList(); //objects

    public void GetInputA1(string agentOneInput)
    {
        agentOneAVals = System.Array.ConvertAll(agentOneInput.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries), float.Parse);
        int numItems = agentOneAVals.Length;

        //clear everything
        for (int i = 0; i < agentA1.Count; i++)
        {
            //destroy object in unity
            GameObject removing = (GameObject)agentA1[agentA1.Count - 1];
            Destroy(removing);

            //remove object from list
            agentA1.RemoveAt(agentA1.Count - 1);
        }

        //create everything
        float currentSize = -2.5f;
        for (int i = 0; i < numItems; i++)
        {
            //create square
            GameObject square = Instantiate(SquarePrefab);
            Transform squareTransform = square.GetComponent<Transform>();

            //resize:
            Transform transform = square.GetComponent<Transform>();
            Vector3 newScale = transform.localScale;
            newScale.y *= agentOneAVals[i];
            transform.localScale = newScale;

            //transform position:
            square.transform.position = new Vector3(-6.25f, currentSize + (agentOneAVals[i] / 2), 0.0f);

            //save and update data:
            agentA1.Add(square);
            currentSize = currentSize + (agentOneAVals[i] * 0.90f);
        }
    }

    private float[] agentTwoAVals; //values
    private ArrayList agentA2 = new ArrayList(); //objects

    public void GetInputA2(string agentTwoInput)
    {
        agentTwoAVals = System.Array.ConvertAll(agentTwoInput.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries), float.Parse);
        int numItems = agentTwoAVals.Length;

        //clear everything
        for (int i = 0; i < agentA2.Count; i++)
        {
            //destroy object in unity
            GameObject removing = (GameObject)agentA2[agentA2.Count - 1];
            Destroy(removing);

            //remove object from list
            agentA2.RemoveAt(agentA2.Count - 1);
        }

        //create everything
        float currentSize = -2.5f;
        for (int i = 0; i < numItems; i++)
        {
            //create square
            GameObject square = Instantiate(SquarePrefab);
            Transform squareTransform = square.GetComponent<Transform>();

            //resize:
            Transform transform = square.GetComponent<Transform>();
            Vector3 newScale = transform.localScale;
            newScale.y *= agentTwoAVals[i];
            transform.localScale = newScale;

            //transform position:
            square.transform.position = new Vector3(-2.75f, currentSize + (agentTwoAVals[i] / 2), 0.0f);

            //save and update data:
            agentA2.Add(square);
            currentSize = currentSize + (agentTwoAVals[i] * 0.9f);
        }
    }


    private float[] agentOneBVals; //values
    private ArrayList agentB1 = new ArrayList(); //objects

    public void GetInputB1(string agentOneInput)
    {
        agentOneBVals = System.Array.ConvertAll(agentOneInput.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries), float.Parse);
        int numItems = agentOneBVals.Length;

        //clear everything
        for (int i = 0; i < agentB1.Count; i++)
        {
            //destroy object in unity
            GameObject removing = (GameObject)agentB1[agentB1.Count - 1];
            Destroy(removing);

            //remove object from list
            agentB1.RemoveAt(agentB1.Count - 1);
        }

        //create everything
        float currentSize = -2.5f;
        for (int i = 0; i < numItems; i++)
        {
            //create square
            GameObject square = Instantiate(SquarePrefab);
            Transform squareTransform = square.GetComponent<Transform>();

            //resize:
            Transform transform = square.GetComponent<Transform>();
            Vector3 newScale = transform.localScale;
            newScale.y *= agentOneBVals[i];
            transform.localScale = newScale;

            //transform position:
            square.transform.position = new Vector3(2.75f, currentSize + (agentOneBVals[i] / 2), 0.0f);

            //save and update data:
            agentB1.Add(square);
            currentSize = currentSize + (agentOneBVals[i] * 0.9f);
        }
    }

    private float[] agentTwoBVals; //values
    private ArrayList agentB2 = new ArrayList(); //objects

    public void GetInputB2(string agentTwoInput)
    {
        agentTwoBVals = System.Array.ConvertAll(agentTwoInput.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries), float.Parse);
        int numItems = agentTwoBVals.Length;

        //clear everything
        for (int i = 0; i < agentB2.Count; i++)
        {
            //destroy object in unity
            GameObject removing = (GameObject)agentB2[agentB2.Count - 1];
            Destroy(removing);

            //remove object from list
            agentB2.RemoveAt(agentB2.Count - 1);
        }

        //create everything
        float currentSize = -2.5f;
        for (int i = 0; i < numItems; i++)
        {
            //create square
            GameObject square = Instantiate(SquarePrefab);
            Transform squareTransform = square.GetComponent<Transform>();

            //resize:
            Transform transform = square.GetComponent<Transform>();
            Vector3 newScale = transform.localScale;
            newScale.y *= agentTwoBVals[i];
            transform.localScale = newScale;

            //transform position:
            square.transform.position = new Vector3(6.25f, currentSize + (agentTwoBVals[i] / 2), 0.0f);

            //save and update data:
            agentB2.Add(square);
            currentSize = currentSize + (agentTwoBVals[i] * 0.9f);
        }
    }


} //GameController
