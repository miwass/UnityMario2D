﻿using UnityEngine;

namespace MarioWorldForAll
{
    public class Goomla : Enemy
    {

        [SerializeField] private float powerImpulse;

        private Rigidbody2D rbody2d;
        private MobMove move;
        private Animator _animator;

        void Awake()
        {
            rbody2d = GetComponent<Rigidbody2D>();
            move = GetComponent<MobMove>();

            _animator = GetComponentInParent<Animator>();
        }

        public override void OnRayCastEnter()
        {
           // Debug.Log("RaycastEnter");
            GetComponent<CapsuleCollider2D>().enabled = false;
            GetComponentInChildren<BoxCollider2D>().enabled = false;
            _animator.enabled = false;
            rbody2d.constraints = RigidbodyConstraints2D.None;
            transform.rotation = Quaternion.Euler(0, 0, 180);
            rbody2d.AddForce(new Vector2(0, 1 * powerImpulse), ForceMode2D.Impulse);
            GameController.instance.PlaySound("smb_stomp");
            move.enabled = false;
            rbody2d.gravityScale = 3;
            Destroy(gameObject, 1.5f);
        }

       //private void OnCollisionEnter2D(Collision2D other)
       // {
       //     if (other.gameObject.CompareTag(Tags.Player))
       //     {
       //         Debug.Log(other.relativeVelocity.magnitude);

       //         foreach (ContactPoint2D contact in other.contacts)
       //         {
       //             print(contact.collider.name + " hit " + contact.otherCollider.name);
       //             print(" contact.point " + contact.point + "\ncontact.normal" + contact.normal);
       //         }

       //         CurrentCharacter.character.OnGoombasEnter();
       //     }
       // }


        /*private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }*/

    }
}