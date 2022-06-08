using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBehaviour : MonoBehaviour
{
    public Animator _animator;
    Vector2 horizontalMovementVector;
    Vector2 verticalMovementVector;

    float horizontalAxisInput;
    float verticalAxisInput;
    // Start is called before the first frame update
    void Start()
    {
      //  _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        verticalAxisInput = Input.GetAxis("Vertical");
        horizontalAxisInput = Input.GetAxis("Horizontal");

       /* _animator.SetFloat("vertical", verticalAxisInput);       
        _animator.SetFloat("horizontal", horizontalAxisInput);*/
       if(verticalAxisInput == 0 && horizontalAxisInput==0)
        {
            _animator.SetFloat("vertical", 0);
            _animator.SetFloat("horizontal", 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
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
        }

    }
}
