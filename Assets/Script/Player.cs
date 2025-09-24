using JetBrains.Annotations;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.LowLevelPhysics;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   public float velocidade = 1;
   public float horizon;
   public float verti;
    
   float cristaly;
   int morte;

   bool cutscene = false;
   bool leveldisponivel = false;
   SpriteRenderer chave;
   FollowTarget target;
 
   Light2D luz1;
   Light2D luz2;
   Light2D luz3;
   Light2D luz4;
   Light2D luz5;
   Light2D luz6;
   Light2D luz7;
   Light2D luz8;
   Light2D luz9;
   Light2D luz10;
   Light2D luz11;
   Light2D luz12;
   Light2D luz13;
   Light2D luz14;
   Light2D luz15;
   Light2D luz16;
   Light2D luz17;
   Light2D luz18;
   Light2D luz19;
   Light2D luz20;
   Light2D luz21;
   Light2D luz22;
   Light2D luz23;
   Light2D luz24;
   Light2D luz25;
   Light2D luz26;
   Light2D luz27;
   Light2D luz28;
   Light2D luz29;
   Light2D luz30;
   Light2D luz31;
   Light2D luz32;
   Light2D luz35;
   Light2D luz36;

   Follow2 target2;
   Inimigo target3;
   Follow targetcamera;
   BoxCollider2D chavecolide;
   Vector2 vect;
  
   Animator anima;
    //Transform npc;
   Rigidbody2D rigi;
   TextMeshProUGUI texto;
   TextMeshProUGUI texto2;

    void Start()
    {
        rigi = transform.GetComponent<Rigidbody2D>();
        
        anima = transform.GetComponent<Animator>();
        texto = GameObject.Find("Cristal").transform.GetComponent<TextMeshProUGUI>();
        texto2 = GameObject.Find("Morte").transform.GetComponent<TextMeshProUGUI>();
        vect = transform.position;
        chave = GameObject.Find("chave").GetComponent<SpriteRenderer>();
        chavecolide = GameObject.Find("chave").GetComponent<BoxCollider2D>();
        target2 = GameObject.Find("Main Camera").GetComponent<Follow2>();
        target3 = GameObject.Find("dark").GetComponent<Inimigo>();
        target = GameObject.Find("chave").GetComponent<FollowTarget>();
        targetcamera = GameObject.Find("Main Camera").GetComponent<Follow>();
        luz1 = GameObject.FindWithTag("1").GetComponent<Light2D>();
        luz2 = GameObject.FindWithTag("2").GetComponent<Light2D>();
        luz3 = GameObject.FindWithTag("3").GetComponent<Light2D>();
        luz4 = GameObject.FindWithTag("4").GetComponent<Light2D>();
        luz5 = GameObject.FindWithTag("5").GetComponent<Light2D>();
        luz6 = GameObject.FindWithTag("6").GetComponent<Light2D>();
        luz7 = GameObject.FindWithTag("7").GetComponent<Light2D>();
        luz8 = GameObject.FindWithTag("8").GetComponent<Light2D>();
        luz9 = GameObject.FindWithTag("9").GetComponent<Light2D>();
        luz10 = GameObject.FindWithTag("10").GetComponent<Light2D>();
        luz11 = GameObject.FindWithTag("11").GetComponent<Light2D>();
        luz12 = GameObject.FindWithTag("12").GetComponent<Light2D>();
        luz13 = GameObject.FindWithTag("13").GetComponent<Light2D>();
        luz14 = GameObject.FindWithTag("14").GetComponent<Light2D>();
        luz15 = GameObject.FindWithTag("15").GetComponent<Light2D>();
        luz16 = GameObject.FindWithTag("16").GetComponent<Light2D>();
        luz17 = GameObject.FindWithTag("17").GetComponent<Light2D>();
        luz18 = GameObject.FindWithTag("18").GetComponent<Light2D>();
        luz19 = GameObject.FindWithTag("19").GetComponent<Light2D>();
        luz20 = GameObject.FindWithTag("20").GetComponent<Light2D>();
        luz21 = GameObject.FindWithTag("21").GetComponent<Light2D>();
        luz22 = GameObject.FindWithTag("22").GetComponent<Light2D>();
        luz23 = GameObject.FindWithTag("23").GetComponent<Light2D>();
        luz24 = GameObject.FindWithTag("24").GetComponent<Light2D>();
        luz25 = GameObject.FindWithTag("25").GetComponent<Light2D>();
        luz26 = GameObject.FindWithTag("26").GetComponent<Light2D>();
        luz27 = GameObject.FindWithTag("27").GetComponent<Light2D>();
        luz28 = GameObject.FindWithTag("28").GetComponent<Light2D>();
        luz29 = GameObject.FindWithTag("29").GetComponent<Light2D>();
        luz30 = GameObject.FindWithTag("30").GetComponent<Light2D>();
        luz31 = GameObject.FindWithTag("31").GetComponent<Light2D>();
        luz32 = GameObject.FindWithTag("32").GetComponent<Light2D>();
        luz35 = GameObject.FindWithTag("35").GetComponent<Light2D>();
        luz36 = GameObject.FindWithTag("36").GetComponent<Light2D>();

        chave.enabled = !chave.enabled;
        chavecolide.enabled = !chavecolide.enabled;
        target.enabled = !target.enabled;
        target2.enabled = !target2.enabled;
        target3.enabled = true;
        targetcamera.enabled = true;

        
        luz1.enabled = true;

        luz2.enabled = true;

        luz3.enabled = true;

        luz4.enabled = true;

        luz5.enabled = true;

        luz6.enabled = true;

        luz7.enabled = true;

        luz8.enabled = true;

        luz9.enabled = true;

        luz10.enabled = true;
        luz11.enabled = true;
        luz12.enabled = true;
        luz13.enabled = true;
        luz14.enabled = true;
        luz15.enabled = true;
        luz16.enabled = true;
        luz17.enabled = true;
        luz18.enabled = true;
        luz19.enabled = true;
        luz20.enabled = true;
        luz21.enabled = true;
        luz22.enabled = true;
        luz23.enabled = true;
        luz24.enabled = true;
        luz25.enabled = true;
        luz26.enabled = true;
        luz27.enabled = true;
        luz28.enabled = true;
        luz29.enabled = true;
        luz30.enabled = true;
        luz31.enabled = true;
        luz32.enabled = true;
        luz35.enabled = true;
        luz36.enabled = true;

       

    }


    // Update is called once per frame
    void Update()
    {

        if (!cutscene)
        {

            ProcessaInputs();
        }
      
        //RotacionaCutscene();
    }

    private void FixedUpdate()
    {
        //cutscene = false;
        MovePers();



        Rotaciona();

        // RotacionaMouse();

    }

    void ProcessaInputs()
    {
        horizon = Input.GetAxisRaw("Horizontal");
        verti = Input.GetAxisRaw("Vertical");

    }
    void MovePers()
    {
        Vector2 movimento = new Vector2(horizon, verti);

        if (movimento.magnitude > 0)
        {
            movimento = movimento.normalized;
        }

        movimento = movimento * velocidade;


        rigi.linearVelocity = movimento;

        if (horizon < 0.1f && horizon > -0.1f && verti < 0.1f && verti > -0.1f)
        {
            anima.SetBool("estaAndando", false);
        }
        else
        {
            anima.SetBool("estaAndando", true);
        }
    }

    void Rotaciona()
    {
        // return earle
        if (horizon == 1)
        {
            transform.eulerAngles = new Vector2(0, 0);

        }

        if (horizon == -1)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }

    }

    //void RotacionaMouse()
    //{
    //    Vector3 poseMundMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Util.OlharObj(transform, poseMundMouse);
    //}

    //void RotacionaCutscene()
    //{


    //    if (Input.GetKey(KeyCode.T))
    //    {
    //        cutscene = true;
    //        Util.OlharObj(transform, GameObject.Find("NPC").gameObject.transform.position);


    //    }


    //    if (Input.GetKey(KeyCode.G) && cutscene == true)
    //    {
    //        cutscene = false;
    //        return;

    //    }


    //}
    void voltacamera()
    {
        targetcamera.enabled = true;
        target2.enabled = false;
        target3.enabled = true;
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains("dark") == true)
        {
            transform.position = vect;
            morte++;
            texto2.text = " <color=purple>" + morte + "</color> /3";


        }

        if (collision.gameObject.name.Contains("cristal") == true)
        {
            cristaly++;
            Destroy(collision.gameObject);
            if(cristaly >= 5)
            {
              GameObject.Find("dark").transform.GetComponent<Inimigo>().velo += 2;
            }

            if (collision.gameObject.name.Contains("cristal1") == true)
            {
                luz2.enabled = false; 
                luz3.enabled = false; 
                luz4.enabled = false;
                luz8.enabled = false;
                luz9.enabled = false;
            }
            if (collision.gameObject.name.Contains("cristal2") == true)
            {
               luz17.enabled = false;
               luz18.enabled = false;
               luz19.enabled = false;   
               luz21.enabled = false;
            }
            if (collision.gameObject.name.Contains("cristal3") == true)
            {
               luz1.enabled = false;
               luz2.enabled = false;
               luz7.enabled = false;
               luz32.enabled = false;
            }
            if (collision.gameObject.name.Contains("cristal4") == true)
            {
               luz10.enabled = false;
               luz11.enabled = false;
               luz13.enabled = false;
               luz30.enabled = false;
            }      
            if (collision.gameObject.name.Contains("cristal5") == true)
            {
               luz11.enabled = false;
               luz30.enabled = false;
               luz31.enabled = false;
                
            
            }
            if (collision.gameObject.name.Contains("cristal6") == true)
            {  
               luz12.enabled = false;
               luz13.enabled = false;
               luz14.enabled = false;          
            }

            if (collision.gameObject.name.Contains("cristal7") == true)
            {
               luz5.enabled = false;
               luz9.enabled = false;
               luz10.enabled = false;
               luz11.enabled = false;
               luz22.enabled = false;
               luz36.enabled = false;
            }
            if (collision.gameObject.name.Contains("cristal8") == true)
            {
               luz6.enabled = false;
               luz25.enabled = false;
               luz26.enabled = false;
               luz28.enabled = false;
               luz29.enabled = false;  
               luz35.enabled = false;
            }

            if (collision.gameObject.name.Contains("cristal9") == true)
            {
               luz22.enabled = false;
               luz23.enabled = false;
               luz24.enabled = false;
               luz27.enabled = false;          
            }


            if (collision.gameObject.name.Contains("cristal10") == true)
            {
               luz14.enabled = false;
               luz15.enabled = false;
               luz16.enabled = false;
               luz20.enabled = false;
            }
            //Debug.Log("Parabéns !! Você pegou:" + n++);

            texto.text = " <color=purple>" + cristaly + "</color> /10";

            if (cristaly == 10 )
            {
                chave.enabled = true;
                chavecolide.enabled = true;
                targetcamera.enabled = false;
            target2.enabled = true;
            target3.enabled = false;
                Invoke("voltacamera", 2);
                //tempo+=353;
         
            }
        }

        if (morte == 3)
        {
            SceneManager.LoadScene("Derrota");
            Invoke("voltaMenu", 2.5f);
        }

        if (collision.gameObject.name.Contains("chave") == true)
        {
            leveldisponivel = true;
            target.enabled = true;
            chavecolide.enabled = false;

        }

        if (collision.gameObject.CompareTag("Porta") == true && leveldisponivel == false)
        {
            SceneManager.LoadScene("Tutorial");
        }

        if (collision.gameObject.CompareTag("Porta") == true && leveldisponivel == true)
        {
            SceneManager.LoadScene("Vitoria");
        }

    }
}

