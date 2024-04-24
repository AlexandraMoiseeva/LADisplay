using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using UnityEngine;
//using UnityEngine.tvOS;
using Unity.VisualScripting;


public static class Data
{
    static public Color ourGreen = new Color(40.0f / 255, 224.0f / 255, 0.0f / 255);
    static public Color ourYellow = new Color(255.0f / 215, 224.0f / 255, 0.0f / 255);
    static public Color ourOrange = new Color(255.0f / 255, 121.0f / 255, 0.0f / 255);
    static public Color ourRed = new Color(230.0f / 255, 0.0f / 255, 0.0f / 255);

    static public int alpha = 150;

    static public float greenR;
    static public float greenG;
    static public float greenB;

    static public float yellowR;
    static public float yellowG;
    static public float yellowB;

    static public float orangeR;
    static public float orangeG;
    static public float orangeB;

    static public float redR;
    static public float redG;
    static public float redB;

    static public float positionX = 0;
    static public float positionY = 0;
    static public float positionZ = 0;

    static public float velocityX = 0;
    static public float velocityY = 0;
    static public float velocityZ = 0;

    static public float angleAttack = 0;
    static public float sidingAttack = 0;

    static public float roll = 0;
    static public float yaw = 0;
    static public float pitch = 0;

    public static void InitValue()
    {
        ourGreen = new Color(40.0f / 255, 224.0f / 255, 0.0f / 255);
        ourYellow = new Color(255.0f / 215, 224.0f / 255, 0.0f / 255);
        ourOrange = new Color(255.0f / 255, 121.0f / 255, 0.0f / 255);
        ourRed = new Color(230.0f / 255, 0.0f / 255, 0.0f / 255);

        alpha = 150;
    }

    public static void Save()
    {
        PlayerPrefs.SetFloat("greenR", ourGreen.r);
        PlayerPrefs.SetFloat("greenG", ourGreen.g);
        PlayerPrefs.SetFloat("greenB", ourGreen.b);

        PlayerPrefs.SetFloat("yellowR", ourYellow.r);
        PlayerPrefs.SetFloat("yellowG", ourYellow.g);
        PlayerPrefs.SetFloat("yellowB", ourYellow.b);

        PlayerPrefs.SetFloat("orangeR", ourOrange.r);
        PlayerPrefs.SetFloat("orangeG", ourOrange.g);
        PlayerPrefs.SetFloat("orangeB", ourOrange.b);

        PlayerPrefs.SetFloat("redR", ourRed.r);
        PlayerPrefs.SetFloat("redG", ourRed.g);
        PlayerPrefs.SetFloat("redB", ourRed.b);

        PlayerPrefs.SetInt("alpha", alpha);
    }
    public static void Load()
    {
        greenR = PlayerPrefs.GetFloat("greenR", ourGreen.r);
        greenG = PlayerPrefs.GetFloat("greenG", ourGreen.g);
        greenB = PlayerPrefs.GetFloat("greenB", ourGreen.b);

        yellowR = PlayerPrefs.GetFloat("yellowR", ourYellow.r);
        yellowG = PlayerPrefs.GetFloat("yellowG", ourYellow.g);
        yellowB = PlayerPrefs.GetFloat("yellowB", ourYellow.b);

        orangeR = PlayerPrefs.GetFloat("orangeR", ourOrange.r);
        orangeG = PlayerPrefs.GetFloat("orangeG", ourOrange.g);
        orangeB = PlayerPrefs.GetFloat("orangeB", ourOrange.b);

        redR = PlayerPrefs.GetFloat("redR", ourRed.r);
        redG = PlayerPrefs.GetFloat("redG", ourRed.g);
        redB = PlayerPrefs.GetFloat("redB", ourRed.b);

        alpha = PlayerPrefs.GetInt("alpha", alpha);

        ourGreen = new Color(greenR, greenG, greenB);
        ourYellow = new Color(yellowR, yellowG, yellowB);
        ourOrange = new Color(orangeR, orangeG, orangeB);
        ourRed = new Color(redR, redG, redB);

        /*
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
        */


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
