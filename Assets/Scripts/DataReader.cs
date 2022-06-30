using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class DataReader : MonoBehaviour
{
    public List<float> _frameArray = new List<float>();
    
    public List<float> _team = new List<float>();
    public List<float> _trackingID = new List<float>();
    public List<float> _playerNumber = new List<float>();
    public List<float> _xPos = new List<float>();
    public List<float> _yPos = new List<float>();
    public List<float> _speed = new List<float>();
    
    public List<float> _xBalPos = new List<float>();
    public List<float> _yBalPos = new List<float>();
    public List<float> _zBalPos = new List<float>();
    public List<float> _ballSpeed = new List<float>();
    public List<float> _clickerFlags = new List<float>();
    void Awake()
    {
        string readFromFilePath = "Assets/Data/SimulationData.dat";
        List<string> fileLines = File.ReadLines(readFromFilePath).ToList();

        for (int i = 0; i < fileLines.Count; i++)
        {
            string lastestSubstring, parseString = fileLines[i];
            //find the frame count and then puts it in an array to use later.
            //removing the argument that I passed so I can continue where I left of

            lastestSubstring = parseString.Substring(0, parseString.IndexOf(":"));
            _frameArray.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _team.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _trackingID.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _playerNumber.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _xPos.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _yPos.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);

            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _speed.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 3);

            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _xBalPos.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 2);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _yBalPos.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);

            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _zBalPos.Add(float.Parse(lastestSubstring));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            lastestSubstring = parseString.Substring(0, parseString.IndexOf(","));
            _ballSpeed.Add(float.Parse((lastestSubstring)));
            parseString = parseString.Remove(0, lastestSubstring.Length + 1);
            
            _clickerFlags.Add(float.Parse(parseString.Substring(0, parseString.IndexOf(","))));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
