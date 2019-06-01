using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class CodeGenerator : MonoBehaviour
{
    private System.Random _rng = new System.Random();
    private List<string> _codes = new List<string>();
    private List<string> _chars = new List<string>()
    { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
      "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

    void Start()
    {
        for(int i = 0; i < 250; i++)
        {
            _codes.Add(GenerateCode());
        }

        PrintCodes();
    }

    private string GenerateCode()
    {
        string randomCode = "";

        while(randomCode.Equals("") && _codes.Contains(randomCode))
        {
            while (randomCode.Length < 8)
            {
                randomCode += _chars[_rng.Next(0, _chars.Count)];
            }
        }       
        return randomCode;
    }

    private void PrintCodes()
    {
        File.WriteAllLines("C:\\Users\\Maxah\\Downloads\\codes.txt", _codes.ToArray());
    }
}
