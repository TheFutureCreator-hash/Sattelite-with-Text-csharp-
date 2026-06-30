using System;

public class Satelite // We define the satelite first
{
    private int _battery = 100;
    private int _altitude = 500;
    private int _scienceData = 0;
    private bool _panelsOpen = false;

    public void Scan(int intensity) 
    {
        int energyCost = intensity * 2; // The battery decline depends of the number of data
        _battery -= energyCost;
        _scienceData += intensity;
        Console.WriteLine($"[ACTION] Scanning with intensity {intensity}. Energy cost: {energyCost}%");
    }

    public void Transmit()
    {
        int energyCost = _scienceData / 2;
        _battery -= energyCost;
        Console.WriteLine($"[ACTION] Transmitting {_scienceData}MB. Energy cost: {energyCost}%");
        _scienceData = 0;
    }

    public void RaiseAltitude()
    {
        _battery -= 20;
        _altitude += 50;
        Console.WriteLine("[ACTION] Activating thrusters to raise altitude...");
    }

    public void LowerAltitude()
    {
        _battery -= 20;
        _altitude -= 50;
        Console.WriteLine("[ACTION] Activating thrusters to lower altitude...");
    }

    public void Recharge()
    {
        _panelsOpen = true;
        _battery += 25;
        if (_battery > 100) _battery = 100;
        Console.WriteLine("[ACTION] Solar panels deployed. Recharging...");
    }

    public int GetBattery() => _battery;
    public int GetAltitude() => _altitude;
    public int GetScienceData() => _scienceData;
}

