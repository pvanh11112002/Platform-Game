using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    //Rigidbody2D rb;
    //public float donhay = 10f;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();   
    //}

    //// Update is called once per frame
    ////void Update()
    ////{
    ////    if(Input.GetKeyDown(KeyCode.Space))
    ////    {
    ////        rb.velocity = new Vector2(0, donhay);
    ////        Debug.Log("hihihi"); 
    ////    }

    ////}
    //public void OnJump(InputAction.CallbackContext context)
    //{
    //    if (context.started)
    //    {
    //        rb.velocity = new Vector2(0, donhay);
    //        Debug.Log(rb.velocity.y);
    //    }
    //}
    private void Start()
    {
        UIManager.Instance.OpenUI<CanvasMainMenu>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            UIManager.Instance.CloseAll();
            UIManager.Instance.GetUI<CanvasGamePlay>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UIManager.Instance.CloseAll();
            UIManager.Instance.GetUI<CanvasVictory>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UIManager.Instance.CloseAll();
            UIManager.Instance.GetUI<CanvasFail>();
        }

    }
}
