using UnityEngine;
using System.Collections;

public class ControllerInput : MonoBehaviour
{

    public GameObject rangeAttack;
    Player Player;


    private void Start()
    {
        Player = FindObjectOfType<Player>();
        if (Player == null)
            Debug.LogError("There are no Player character on scene");
    }

    private void Update()
    {
        // rangeAttack.SetActive(GameManager.Instance.Bullet > 0 ? true : false);

        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }

#if !UNITY_ANDROID
        if(Input.GetMouseButtonDown(0))
		{
			RangeAttack();
		}
#endif
    }



    public void MoveLeft()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.MoveLeft();
    }

    public void MoveRight()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.MoveRight();
    }

    public void FallDown()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.FallDown();
    }


    public void StopMove()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.StopMove();
    }

    public void Jump()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.Jump();
    }

    public void JumpOff()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.JumpOff();
    }

    public void MeleeAttack()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.MeleeAttack();
    }

    public void RangeAttack()
    {
        if (GameManager.Instance.State == GameManager.GameState.Playing)
            Player.RangeAttack();
    }

}
