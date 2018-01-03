using System.Collections.Generic;
using UnityEngine;

public class UpdateManager: MonoBehaviour
{
    private List<IUpdate> toUpdate = new List<IUpdate>();
    public static UpdateManager instance { get { return _instance; } }
    private static UpdateManager _instance;

    public void Start()
    {
        if (_instance == null)
            _instance = this;
    }

    public void AddUpdate(IUpdate updateObj)
    {
        toUpdate.Add(updateObj);
    }

    public void RemoveUpdate(IUpdate updateObj)
    {
        toUpdate.Remove(updateObj);
    }

    public void Update()
    {
        foreach (var item in toUpdate)
            item.Update();
    }
}


public interface IUpdate{
    void Update();
   
}