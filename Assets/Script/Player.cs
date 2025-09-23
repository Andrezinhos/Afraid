using JetBrains.Annotations;
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
    bool menu = false;
    bool vitoria = false;

    public float cristaly;
    float cristaly2;
    int morte;

    public bool cutscene = false;
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
    Vector3 vect2;
    bool ativo = false;
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
        luz1 = GameObject.Find("Light 2D1").GetComponent<Light2D>();
        luz2 = GameObject.Find("Light 2D2").GetComponent<Light2D>();
        luz3 = GameObject.Find("Light 2D3").GetComponent<Light2D>();
        luz4 = GameObject.Find("Light 2D4").GetComponent<Light2D>();
        luz5 = GameObject.Find("Light 2D5").GetComponent<Light2D>();
        luz6 = GameObject.Find("Light 2D6").GetComponent<Light2D>();
        luz7 = GameObject.Find("Light 2D7").GetComponent<Light2D>();
        luz8 = GameObject.Find("Light 2D8").GetComponent<Light2D>();
        luz9 = GameObject.Find("Light 2D9").GetComponent<Light2D>();
        luz10 = GameObject.Find("Light 2D10").GetComponent<Light2D>();
        luz11 = GameObject.Find("Light 2D11").GetComponent<Light2D>();
        luz12 = GameObject.Find("Light 2D12").GetComponent<Light2D>();
        luz13 = GameObject.Find("Light 2D13").GetComponent<Light2D>();
        luz14 = GameObject.Find("Light 2D14").GetComponent<Light2D>();
        luz15 = GameObject.Find("Light 2D15").GetComponent<Light2D>();
        luz16 = GameObject.Find("Light 2D16").GetComponent<Light2D>();
        luz17 = GameObject.Find("Light 2D17").GetComponent<Light2D>();
        luz18 = GameObject.Find("Light 2D18").GetComponent<Light2D>();
        luz19 = GameObject.Find("Light 2D19").GetComponent<Light2D>();
        luz20 = GameObject.Find("Light 2D20").GetComponent<Light2D>();
        luz21 = GameObject.Find("Light 2D21").GetComponent<Light2D>();
        luz22 = GameObject.Find("Light 2D22").GetComponent<Light2D>();
        luz23 = GameObject.Find("Light 2D23").GetComponent<Light2D>();
        luz24 = GameObject.Find("Light 2D24").GetComponent<Light2D>();
        luz25 = GameObject.Find("Light 2D25").GetComponent<Light2D>();
        luz26 = GameObject.Find("Light 2D26").GetComponent<Light2D>();
        luz27 = GameObject.Find("Light 2D27").GetComponent<Light2D>();
        luz28 = GameObject.Find("Light 2D28").GetComponent<Light2D>();
        luz29 = GameObject.Find("Light 2D29").GetComponent<Light2D>();
        luz30 = GameObject.Find("Light 2D30").GetComponent<Light2D>();
        luz31 = GameObject.Find("Light 2D31").GetComponent<Light2D>();
        luz32 = GameObject.Find("Light 2D32").GetComponent<Light2D>();
        luz35 = GameObject.Find("Light 2D35").GetComponent<Light2D>();
        luz36 = GameObject.Find("Light 2D36").GetComponent<Light2D>();

        chave.enabled = !chave.enabled;
        chavecolide.enabled = !chavecolide.enabled;
        target.enabled = !target.enabled;
        target2.enabled = !target2.enabled;
        target3.enabled = true;
        targetcamera.enabled = true;


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

        if (collision.gameObject.name.Contains("cristalTuto") == true)
        {
            cristaly2++;
            Destroy(collision.gameObject);

            //Debug.Log("Parabéns !! Você pegou:" + n++);

            texto.text = " <color=purple>" + cristaly + "</color> /5";

            if (cristaly2 == 5)
            {
                chave.enabled = true;
                chavecolide.enabled = true;
                targetcamera.enabled = false;
                target2.enabled = true;
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

        if (collision.gameObject.name.Contains("PortaTuto") == true && leveldisponivel == true)
        {
            SceneManager.LoadScene("Ambiente");
        }

        if (collision.gameObject.CompareTag("Porta") == true && leveldisponivel == true)
        {
            SceneManager.LoadScene("Vitoria");
        }

    }
}

