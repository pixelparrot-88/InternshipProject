using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectPara : MonoBehaviour
{

    public Image[] connectPoints;

    float connection, maxConnection = 100;

    // Start is called before the first frame update
    public void Start()
    {
        connection = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        if (connection > maxConnection) connection = maxConnection;

        ConnectionBarFiller();
    }

    void ConnectionBarFiller()
    {
        for (int i = 0; i < connectPoints.Length; i++)
        {
            connectPoints[i].enabled = !DisplayconnectionPoint(connection, i);
        }
    }

    bool DisplayconnectionPoint(float _connection, int pointNubmber)
    {
        return ((pointNubmber * 10) >= _connection);
    }

    public void Minus(float minusPoints)
    {
        if (connection > 0)
            connection -= minusPoints;
    }

    public void Plus(float plusPoints)
    {
        if (connection < maxConnection)
            connection += plusPoints;
    }

    public void SetConnectionValue(float a)
    {
        connection = a;
    }

    public float GetConnectionValue()
    {
        return connection;
    }
}
