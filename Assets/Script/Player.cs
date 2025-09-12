using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.LowLevelPhysics;
using System.Drawing;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   
    public int velocidade = 1;
    public float horizon;
    public float verti;
    public bool cutscene = false;
    Vector2 vect;
    Transform npc;
    Rigidbody2D rigi;
    TextMeshProUGUI texto;
    float cristaly;

    void Start()
    {
        rigi = transform.GetComponent<Rigidbody2D>();
        //texto = GameObject.Find("Cristal").transform.GetComponent<TextMeshProUGUI>();


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

    }

    void Rotaciona()
    {
        // return earle
        if (verti == 0 && horizon == 0)
        {
            return;
        }

        float angulo = Mathf.Atan2(verti, horizon) * Mathf.Rad2Deg;
        rigi.rotation = angulo;
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



    private void OnCollisionEnter2D(Collision2D collision)
    {

        //if (collision.CompareTag("Abismo") == true)
        //{
        //    transform.position = vect;
        //    n = 0;


        //    Debug.Log("Parabéns !! Você pegou:");

            


        //}
        //if (collision.gameObject.name.Contains("cristal") == true)
        //{
        //    cristaly++;
        //    Destroy(collision.gameObject);

        //    //Debug.Log("Parabéns !! Você pegou:" + n++);

        //    texto.text = " <color=purple>" + cristaly + "</color> /5";
        //}
    }
}
