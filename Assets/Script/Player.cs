using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.LowLevelPhysics;

public class Personagem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Transform npc;
    Rigidbody2D rigi;
    public int velocidade = 1;
    public float horizon;
    public float verti;
    public bool cutscene = false;

    void Start()
    {
        rigi = transform.GetComponent<Rigidbody2D>();


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



        //Rotaciona();

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
}
