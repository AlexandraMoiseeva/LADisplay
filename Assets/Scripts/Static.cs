using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using UnityEngine;
using UnityEngine.tvOS;
using Unity.VisualScripting;


public static class Data
{
    static public Color ourGreen = new Color(40.0f / 255, 224.0f / 255, 0.0f / 255);
    static public Color ourYellow = new Color(255.0f / 215, 224.0f / 255, 0.0f / 255);
    static public Color ourOrange = new Color(255.0f / 255, 121.0f / 255, 0.0f / 255);
    static public Color ourRed = new Color(230.0f / 255, 0.0f / 255, 0.0f / 255);

    static public int alpha = 150;

    static public float positionX;
    static public float positionY;
    static public float positionZ;

    static public float velocityX;
    static public float velocityY;
    static public float velocityZ;

    static public float angleAttack;
    static public float sidingAttack;

    static public float roll;
    static public float yaw;
    static public float pitch;

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

        roll = PlayerPrefs.GetFloat("roll", 0);
        yaw = PlayerPrefs.GetFloat("yaw", 0);
        pitch = PlayerPrefs.GetFloat("pitch", 0);
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

        PlayerPrefs.DeleteKey("roll");
        PlayerPrefs.DeleteKey("yaw");
        PlayerPrefs.DeleteKey("pitch");
    }

}
