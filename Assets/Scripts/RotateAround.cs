using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject centerAngleAttack;
    public GameObject targetAngleAttack;

    public GameObject centerSideAttack;
    public GameObject targetSideAttack;

    private float angleAttackInit;
    private float sideAttackInit;
    private float pitchAngle;
    void Start()
    {
        angleAttackInit = 0;
        sideAttackInit = 0;
        pitchAngle = 0;
        targetAngleAttack.transform.RotateAround(centerAngleAttack.transform.position, Vector3.back, 180);
    }

    // Update is called once per frame
    void Update()
    {
        targetAngleAttack.transform.RotateAround(centerAngleAttack.transform.position, Vector3.back, 360  * (-Data.angleAttack + angleAttackInit));
        targetSideAttack.transform.RotateAround(centerSideAttack.transform.position, Vector3.back, 360 * (-Data.sidingAttack + sideAttackInit));

        if (Data.velocityX != 0 & Data.velocityY != 0)
            targetSideAttack.transform.position += new Vector3(0, pitchAngle - System.MathF.Atan(Data.velocityZ/
            System.MathF.Sqrt(Data.velocityY * Data.velocityY + Data.velocityX * Data.velocityX)), 0);
        angleAttackInit = Data.angleAttack;
        sideAttackInit = Data.sidingAttack;
    }

}
