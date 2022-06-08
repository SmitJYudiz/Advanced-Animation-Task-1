using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using UniversalMobileController;
public class PlayerTouchController : MonoBehaviour
{
    public Animator _animator;
    Vector2 horizontalMovementVector;
    Vector2 verticalMovementVector;

    float horizontalAxisInput;
    float verticalAxisInput;

    public VariableJoystick joystick;

    //public Button jumpButton;

    public List<AnimationClip> attackAnimClips;
    public AnimationState attackState;
    
    // Start is called before the first frame update
    void Start()
    {
      //  _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
       /* verticalAxisInput = Input.GetAxis("Vertical");
        horizontalAxisInput = Input.GetAxis("Horizontal");*/

        horizontalAxisInput = joystick.Horizontal;
        Debug.Log(horizontalAxisInput);

        verticalAxisInput = joystick.Vertical;
        Debug.Log(verticalAxisInput);

        

       /* _animator.SetFloat("vertical", verticalAxisInput);       
        _animator.SetFloat("horizontal", horizontalAxisInput);*/
       if(verticalAxisInput == 0 && horizontalAxisInput==0)
        {
            _animator.SetFloat("vertical", 0);
            _animator.SetFloat("horizontal", 0);
        }

       if(horizontalAxisInput !=0  || verticalAxisInput !=0)
        {
            _animator.SetFloat("vertical", verticalAxisInput);
            _animator.SetFloat("horizontal", horizontalAxisInput);
        }


       
       //Legacy code
       /* if (horizontalAxisInput > 0)
        {
            if (horizontalAxisInput < 0.5f)
            {
                _animator.SetFloat("horizontal", 0.5f);
            }
            if (horizontalAxisInput >= 0.5f)
            {
                _animator.SetFloat("horizontal", 1f);

            }
        }

        if (horizontalAxisInput < 0)
        {
            if (horizontalAxisInput > -0.5f)
            {
                _animator.SetFloat("horizontal", -0.5f);
            }
            else
            {
                _animator.SetFloat("horizontal", -1f);
            }
        }

        if (verticalAxisInput > 0)
        {
            if (verticalAxisInput < 0.5f)
            {
                _animator.SetFloat("vertical", 0.5f);
            }
            else
            {
                _animator.SetFloat("vertical", 1f);
                Debug.Log("run forward");
            }
        }

        if (verticalAxisInput < 0)
        {
            if (verticalAxisInput > -0.5f)
            {
                _animator.SetFloat("vertical", -0.5f);
            }
            else
            {
                _animator.SetFloat("vertical", -1f);
            }
        }*/

       //Legacy code
        /* if (Input.GetKey(KeyCode.LeftShift))
         {
             //here the player will run, so horizontal and vertical set to max    
             if (verticalAxisInput > 0)
             {
                 _animator.SetFloat("vertical", 1);
             }
             if (verticalAxisInput < 0)
             {
                 _animator.SetFloat("vertical", -1);
             }

             if (horizontalAxisInput > 0)
             {

                 _animator.SetFloat("horizontal", 1);
             }
             if (horizontalAxisInput < 0)
             {
                 _animator.SetFloat("horizontal", -1);
             }
         }
         else
         {
             //here walk/slow, so max values only 0.5 or -0.5
             if(verticalAxisInput>0)
             {
                 _animator.SetFloat("vertical", 0.5f);
             }
             if(verticalAxisInput<0)
             {
                 _animator.SetFloat("vertical", -0.5f);
             }

             if(horizontalAxisInput>0)
             {
                 _animator.SetFloat("horizontal", 0.5f);
             }
             if(horizontalAxisInput<0)
             {
                 _animator.SetFloat("horizontal", -0.5f);
             }
         }*/

    }
    public void Jump()
    {
        _animator.SetTrigger("Jump");
    }

    public void OnClickAttack()
    {
        _animator.SetInteger("attack index",Random.Range(0,3));
        _animator.SetTrigger("attack");
      /*  _animator.SetInteger("Attack", Random.Range(0, 2));
        _animator.
        */
    }

}
