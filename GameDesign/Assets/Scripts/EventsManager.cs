using System.Collections.Generic;

public class EventsManager
{
    public delegate void EventReceiver(params object[] parameterContainer);
    private static Dictionary<int, EventReceiver> _events;

    public static void SubscribeToEvent(int eventType, EventReceiver listener)
    {
        if (_events == null)
            _events = new Dictionary<int, EventReceiver>();

        if (!_events.ContainsKey(eventType))
            _events.Add(eventType, null);

        _events[eventType] += listener;
    }
    
    public static void UnsubscribeToEvent(int eventType, EventReceiver listener)
    {
        if (_events != null)
        {
            if (_events.ContainsKey(eventType))
                _events[eventType] -= listener;
        }
    }

    public static void TriggerEvent(int eventType)
    {
        TriggerEvent(eventType, null);
    }
    
    public static void TriggerEvent(int eventType, params object[] parametersWrapper)
    {
        if (_events == null)
        {
            UnityEngine.Debug.LogWarning("No events subscribed");
            return;
        }

        if (_events.ContainsKey(eventType))
        {
            if (_events[eventType] != null)
                _events[eventType](parametersWrapper);
        }
    }
}

public class EventType
{
    public const int GP_ShipDestroyed         = 0;
    public const int GP_AsteroidCreated       = 1;
    public const int GP_AsteroidDestroyed     = 2;
    public const int GP_BombDestroyed         = 3;
    public const int GP_GameOver              = 4;
    public const int GP_Win                   = 5;
    public const int GP_PowCreated            = 6;
    public const int GP_PowCollected          = 7;
    public const int GP_EndBuff               = 8;
    public const int GP_engine                = 9;
    public const int GP_WeaponAutomatic       = 10;
    public const int GP_WeaponNormal          = 11;
    public const int Sys_Pause                = 12;
    public const int Sys_StartGame            = 13;
    public const int Sys_Wave                 = 14;
    public const int Sys_Restar               = 15;
    public const int GP_WeaponLaser           = 16;
    public const int GP_WeaponBasic           = 17;
    public const int GP_BombShooted           = 18;

}