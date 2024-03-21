using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using UnityEngine;
using UnityEngine.tvOS;

public static class Data
{
    static public float positionX;
    static public float positionY;
    static public float positionZ;

    static public float velocityX;
    static public float velocityY;
    static public float velocityZ;

    static public float angleAttack;
    static public float sidingAttack;

    public static void Load()
    {
        positionX = PlayerPrefs.GetFloat("positionX", 0);
        positionY = PlayerPrefs.GetFloat("positionY", 0);
        positionZ = PlayerPrefs.GetFloat("positionZ", 0);

        velocityX = PlayerPrefs.GetFloat("velocityX", 0);
        velocityY = PlayerPrefs.GetFloat("velocityY", 0);
        velocityZ = PlayerPrefs.GetFloat("velocityZ", 0);

        angleAttack = PlayerPrefs.GetFloat("angleAttack", 0);
        sidingAttack = PlayerPrefs.GetFloat("sidingAttack", 0);
    }
    public static void Drop()
    {
        PlayerPrefs.DeleteKey("positionX");
        PlayerPrefs.DeleteKey("positionY");
        PlayerPrefs.DeleteKey("positionZ");

        PlayerPrefs.DeleteKey("velocityX");
        PlayerPrefs.DeleteKey("velocityY");
        PlayerPrefs.DeleteKey("velocityZ");

        PlayerPrefs.DeleteKey("angleAttack");
        PlayerPrefs.DeleteKey("sidingAttack");
    }

}
