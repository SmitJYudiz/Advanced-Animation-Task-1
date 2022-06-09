using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using UniversalMobileController;
public class PlayerTouchController : MonoBehaviour
{
    public Animator _animator;

  float horizontalAxisInput;
    float verticalAxisInput;

    public VariableJoystick movementJoystick;

    public List<AnimationClip> attackAnimClips;
    public AnimationState attackState;

 
    

    // Update is called once per frame
    void Update()
    {
        horizontalAxisInput = movementJoystick.Horizontal;        
        verticalAxisInput = movementJoystick.Vertical;
        
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

        //LookAt();

       
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
    }


    public void LookAt()
    {
        //currentPlayerRotation += new Quaternion.
        //Vector3.Lerp(transform.forward, targetVector);
       // transform.eulerAngles = new Vector3(targetVector.x, targetVector.y, targetVector.z);
        //transform.eulerAngles = new Vector3(targetVector.x, targetVector.y, targetVector.z);
        //transform.eulerAngles = new Vector3(0, lookJoystick.Horizontal*100 + lookJoystick.Vertical*100, 0);
       //transform.eulerAngles = new Vector3(0, -movementJoystick.Horizontal * 100-movementJoystick.Vertical * 100,0);

       /* if(movementJoystick.Vertical > 0)
        {
            transform.eulerAngles = new Vector3(0,  0, 0);
        }
        if(movementJoystick.Vertical<0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if(movementJoystick.Horizontal>0)
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if(movementJoystick.Horizontal<0)
        {
            transform.eulerAngles = new Vector3(0, 270, 0);
        }*/
      //  transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion    ,new Quaternion.Euler( transform.rotation.x,90f, transform.rotation.z));

       

        //    transform.forward.Lerp(transform.forward, targetVector);
        //Mathf.LerpRotation(transform.forward, targetVector, 1.2f);
    }

}