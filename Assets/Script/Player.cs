using JetBrains.Annotations;
using System.Diagnostics.Tracing;
using System.Drawing;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.LowLevelPhysics;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public int velocidade = 1;
    public float horizon;
    public float verti;
  
    float cristaly;
    float cristaly2;
    int morte;
    int tempo;
    public bool cutscene = false;
    bool leveldisponivel = false;
    SpriteRenderer chave;
    FollowTarget target;
    Follow2 target2;
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
        target = GameObject.Find("chave").GetComponent<FollowTarget>();
        targetcamera = GameObject.Find("Main Camera").GetComponent<Follow>();


        chave.enabled = !chave.enabled;
        chavecolide.enabled = !chavecolide.enabled;
        target.enabled = !target.enabled;
        target2.enabled = !target2.enabled;
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

            //Debug.Log("Parabéns !! Você pegou:" + n++);

            texto.text = " <color=purple>" + cristaly + "</color> /35";

            if (cristaly == 35)
            {
                chave.enabled = true;
                chavecolide.enabled = true;
                targetcamera.enabled = false;
                target2.enabled = true;
                Invoke("voltacamera", 2);
                //tempo+=353;
         
            }

        }

        if (collision.gameObject.name.Contains("cristalTuto") == true)
        {
            cristaly2++;
            Destroy(collision.gameObject);

            //Debug.Log("Parabéns !! Você pegou:" + n++);

            texto.text = " <color=purple>" + cristaly + "</color> /35";

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
            SceneManager.LoadScene("Ambiente");
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
            SceneManager.LoadScene("Menu");
        }

    }
}

