using UnityEngine;
using System.Collections;

public class Stats_Changing : MonoBehaviour {

    public void KnowledgeUp()
    {
        if (Stats.Remaining > 0 && Stats.Knowledge < Stats.Max)
        {
            Stats.Remaining -= 1;
            Stats.Knowledge += 1;
        }
        
    }

    public void KnowledgeDown()
    {
        if (Stats.Remaining < Stats.Points && Stats.Knowledge > Stats.StartKnowledge)
        {
            Stats.Remaining += 1;
            Stats.Knowledge -= 1;
        }
    }

    public void ConnectionsUp()
    {
        if (Stats.Remaining > 0 && Stats.Connections < Stats.Max)
        {
            Stats.Remaining -= 1;
            Stats.Connections += 1;
        }
    }

    public void ConnectionsDown()
    {
        if (Stats.Remaining < Stats.Points && Stats.Connections > Stats.StartConnections)
        {
            Stats.Remaining += 1;
            Stats.Connections -= 1;
        }
    }

    public void CheatingUp()
    {
        if (Stats.Remaining > 0 && Stats.Cheating < Stats.Max)
        {
            Stats.Remaining -= 1;
            Stats.Cheating += 1;
        }
    }

    public void CheatingDown()
    {
        if (Stats.Remaining < Stats.Points && Stats.Cheating > Stats.StartCheating)
        {
            Stats.Remaining += 1;
            Stats.Cheating -= 1;
        }
    }

    public void Submit()
    {
        if (Stats.Remaining == 0)
        {
            Stats.StartCheating = Stats.Cheating;
            Stats.StartConnections = Stats.Connections;
            Stats.StartKnowledge = Stats.Knowledge;

			Application.LoadLevel ("pacman");
        }
    }
}
