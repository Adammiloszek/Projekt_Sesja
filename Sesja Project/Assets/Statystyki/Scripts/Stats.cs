using UnityEngine;
using System.Collections;

public static class Stats {


    private static int cheating = 0;
    private static int connections = 0;
    private static int knowledge = 0;

    private const int points = 15;

    private static int remaining = points;


    private static int start_cheating = cheating;
    private static int start_connections = connections;
    private static int start_knowledge = knowledge;
    


    public static int Cheating
    {
        get { return cheating; }
        set { cheating = value; }
    }

    public static int Connections
    {
        get { return connections; }
        set { connections = value; }
    }

    public static int Knowledge
    {
        get { return knowledge; }
        set { knowledge = value; }
    }

    public static int Remaining
    {
        get { return remaining; }
        set { remaining = value; }
    }

    public static int Points
    {
        get { return points; }
    }

    public static int StartCheating
    {
        get { return start_cheating; }
        set { start_cheating = value; }
    }

    public static int StartConnections
    {
        get { return start_connections; }
        set { start_connections = value; }
    }

    public static int StartKnowledge
    {
        get { return start_knowledge; }
        set { start_knowledge = value; }
    }
}
