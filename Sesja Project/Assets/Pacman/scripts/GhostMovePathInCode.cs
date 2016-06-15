using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GhostMovePathInCode : MonoBehaviour {

	private Transform[] waypoints;
	
	public Rigidbody2D rb;

	public Animator animator;




    private static int podejscia = 2;

    public static int Podejscia
    {
        get { return podejscia; }
        set { podejscia = value; }
    }
	
	void Start ()
	{



		rb = GetComponent<Rigidbody2D> ();

		if (this.gameObject.name == "inky(Clone)") {

			waypoints = new Transform[59];
			Debug.Log("inky ");
            waypoints[0] = GameObject.Find("Waypoint88").transform;
            waypoints[1] = GameObject.Find("Waypoint74").transform;
            waypoints[2] = GameObject.Find("Waypoint09").transform;
            waypoints[3] = GameObject.Find("Waypoint08").transform;
            waypoints[4] = GameObject.Find("Waypoint19").transform;
            waypoints[5] = GameObject.Find("Waypoint21").transform;
            waypoints[6] = GameObject.Find("Waypoint00").transform;
            waypoints[7] = GameObject.Find("Waypoint01").transform;
            waypoints[8] = GameObject.Find("Waypoint20").transform;
            waypoints[9] = GameObject.Find("Waypoint18").transform;
            waypoints[10] = GameObject.Find("Waypoint02").transform;
            waypoints[11] = GameObject.Find("Waypoint01").transform;
            waypoints[12] = GameObject.Find("Waypoint33").transform;
            waypoints[13] = GameObject.Find("Waypoint34").transform;
            waypoints[14] = GameObject.Find("Waypoint35").transform;
            waypoints[15] = GameObject.Find("Waypoint36").transform;
            waypoints[16] = GameObject.Find("Waypoint79").transform;
            waypoints[17] = GameObject.Find("Waypoint46").transform;
            waypoints[18] = GameObject.Find("Waypoint60").transform;
            waypoints[19] = GameObject.Find("Waypoint59").transform;
            waypoints[20] = GameObject.Find("Waypoint49").transform;
            waypoints[21] = GameObject.Find("Waypoint48").transform;
            waypoints[22] = GameObject.Find("Waypoint47").transform;
            waypoints[23] = GameObject.Find("Waypoint44").transform;
            waypoints[24] = GameObject.Find("Waypoint25").transform;
            waypoints[25] = GameObject.Find("Waypoint75").transform;
            waypoints[26] = GameObject.Find("Waypoint10").transform;
            waypoints[27] = GameObject.Find("Waypoint11").transform;
            waypoints[28] = GameObject.Find("Waypoint76").transform;
            waypoints[29] = GameObject.Find("Waypoint16").transform;
            waypoints[30] = GameObject.Find("Waypoint04").transform;
            waypoints[31] = GameObject.Find("Waypoint03").transform;
            waypoints[32] = GameObject.Find("Waypoint81").transform;
            waypoints[33] = GameObject.Find("Waypoint80").transform;
            waypoints[34] = GameObject.Find("Waypoint18").transform;
            waypoints[35] = GameObject.Find("Waypoint19").transform;
            waypoints[36] = GameObject.Find("Waypoint08").transform;
            waypoints[37] = GameObject.Find("Waypoint09").transform;
            waypoints[38] = GameObject.Find("Waypoint74").transform;
            waypoints[39] = GameObject.Find("Waypoint25").transform;
            waypoints[40] = GameObject.Find("Waypoint44").transform;
            waypoints[41] = GameObject.Find("Waypoint40").transform;
            waypoints[42] = GameObject.Find("Waypoint57").transform;
            waypoints[43] = GameObject.Find("Waypoint56").transform;
            waypoints[44] = GameObject.Find("Waypoint66").transform;
            waypoints[45] = GameObject.Find("Waypoint65").transform;
            waypoints[46] = GameObject.Find("Waypoint41").transform;
            waypoints[47] = GameObject.Find("Waypoint39").transform;
            waypoints[48] = GameObject.Find("Waypoint38").transform;
            waypoints[49] = GameObject.Find("Waypoint37").transform;
            waypoints[50] = GameObject.Find("Waypoint29").transform;
            waypoints[51] = GameObject.Find("Waypoint28").transform;
            waypoints[52] = GameObject.Find("Waypoint13").transform;
            waypoints[53] = GameObject.Find("Waypoint14").transform;
            waypoints[54] = GameObject.Find("Waypoint05").transform;
            waypoints[55] = GameObject.Find("Waypoint03").transform;
            waypoints[56] = GameObject.Find("Waypoint17").transform;
            waypoints[57] = GameObject.Find("Waypoint16").transform;
            waypoints[58] = GameObject.Find("Waypoint27").transform;
		}


		if (this.gameObject.name == "blinky(Clone)") {
			waypoints = new Transform[66];
			Debug.Log("blinky ");
            waypoints[0] = GameObject.Find("Waypoint88").transform;
            waypoints[1] = GameObject.Find("Waypoint25").transform;
            waypoints[2] = GameObject.Find("Waypoint44").transform;
            waypoints[3] = GameObject.Find("Waypoint45").transform;
            waypoints[4] = GameObject.Find("Waypoint45").transform;
            waypoints[5] = GameObject.Find("Waypoint40").transform;
            waypoints[6] = GameObject.Find("Waypoint57").transform;
            waypoints[7] = GameObject.Find("Waypoint56").transform;
            waypoints[8] = GameObject.Find("Waypoint66").transform;
            waypoints[9] = GameObject.Find("Waypoint67").transform;
            waypoints[10] = GameObject.Find("Waypoint68").transform;
            waypoints[11] = GameObject.Find("Waypoint71").transform;
            waypoints[12] = GameObject.Find("Waypoint62").transform;
            waypoints[13] = GameObject.Find("Waypoint61").transform;
            waypoints[14] = GameObject.Find("Waypoint51").transform;
            waypoints[15] = GameObject.Find("Waypoint52").transform;
            waypoints[16] = GameObject.Find("Waypoint43").transform;
            waypoints[17] = GameObject.Find("Waypoint47").transform;
            waypoints[18] = GameObject.Find("Waypoint48").transform;
            waypoints[19] = GameObject.Find("Waypoint49").transform;
            waypoints[20] = GameObject.Find("Waypoint59").transform;
            waypoints[21] = GameObject.Find("Waypoint58").transform;
            waypoints[22] = GameObject.Find("Waypoint73").transform;
            waypoints[23] = GameObject.Find("Waypoint72").transform;
            waypoints[24] = GameObject.Find("Waypoint07").transform;
            waypoints[25] = GameObject.Find("Waypoint77").transform;
            waypoints[26] = GameObject.Find("Waypoint23").transform;
            waypoints[27] = GameObject.Find("Waypoint22").transform;
            waypoints[28] = GameObject.Find("Waypoint35").transform;
            waypoints[29] = GameObject.Find("Waypoint36").transform;
            waypoints[30] = GameObject.Find("Waypoint79").transform;
            waypoints[31] = GameObject.Find("Waypoint47").transform;
            waypoints[32] = GameObject.Find("Waypoint48").transform;
            waypoints[33] = GameObject.Find("Waypoint49").transform;
            waypoints[34] = GameObject.Find("Waypoint59").transform;
            waypoints[35] = GameObject.Find("Waypoint58").transform;
            waypoints[36] = GameObject.Find("Waypoint73").transform;
            waypoints[37] = GameObject.Find("Waypoint72").transform;
            waypoints[38] = GameObject.Find("Waypoint50").transform;
            waypoints[39] = GameObject.Find("Waypoint52").transform;
            waypoints[40] = GameObject.Find("Waypoint43").transform;
            waypoints[41] = GameObject.Find("Waypoint44").transform;
            waypoints[42] = GameObject.Find("Waypoint25").transform;
            waypoints[43] = GameObject.Find("Waypoint74").transform;
            waypoints[44] = GameObject.Find("Waypoint09").transform;
            waypoints[45] = GameObject.Find("Waypoint08").transform;
            waypoints[46] = GameObject.Find("Waypoint19").transform;
            waypoints[47] = GameObject.Find("Waypoint18").transform;
            waypoints[48] = GameObject.Find("Waypoint20").transform;
            waypoints[49] = GameObject.Find("Waypoint01").transform;
            waypoints[50] = GameObject.Find("Waypoint00").transform;
            waypoints[51] = GameObject.Find("Waypoint21").transform;
            waypoints[52] = GameObject.Find("Waypoint18").transform;
            waypoints[53] = GameObject.Find("Waypoint80").transform;
            waypoints[54] = GameObject.Find("Waypoint81").transform;
            waypoints[55] = GameObject.Find("Waypoint03").transform;
            waypoints[56] = GameObject.Find("Waypoint05").transform;
            waypoints[57] = GameObject.Find("Waypoint15").transform;
            waypoints[58] = GameObject.Find("Waypoint16").transform;
            waypoints[59] = GameObject.Find("Waypoint12").transform;
            waypoints[60] = GameObject.Find("Waypoint14").transform;
            waypoints[61] = GameObject.Find("Waypoint15").transform;
            waypoints[62] = GameObject.Find("Waypoint76").transform;
            waypoints[63] = GameObject.Find("Waypoint11").transform;
            waypoints[64] = GameObject.Find("Waypoint10").transform;
            waypoints[65] = GameObject.Find("Waypoint75").transform;


		}


		if (this.gameObject.name == "clyde(Clone)") {
			waypoints = new Transform[65];
			Debug.Log("clyde ");
            waypoints[0] = GameObject.Find("Waypoint88").transform;
            waypoints[1] = GameObject.Find("Waypoint26").transform;
            waypoints[2] = GameObject.Find("Waypoint45").transform;
            waypoints[3] = GameObject.Find("Waypoint42").transform;
            waypoints[4] = GameObject.Find("Waypoint53").transform;
            waypoints[5] = GameObject.Find("Waypoint55").transform;
            waypoints[6] = GameObject.Find("Waypoint69").transform;
            waypoints[7] = GameObject.Find("Waypoint68").transform;
            waypoints[8] = GameObject.Find("Waypoint67").transform;
            waypoints[9] = GameObject.Find("Waypoint65").transform;
            waypoints[10] = GameObject.Find("Waypoint55").transform;
            waypoints[11] = GameObject.Find("Waypoint54").transform;
            waypoints[12] = GameObject.Find("Waypoint64").transform;
            waypoints[13] = GameObject.Find("Waypoint63").transform;
            waypoints[14] = GameObject.Find("Waypoint70").transform;
            waypoints[15] = GameObject.Find("Waypoint73").transform;
            waypoints[16] = GameObject.Find("Waypoint58").transform;
            waypoints[17] = GameObject.Find("Waypoint59").transform;
            waypoints[18] = GameObject.Find("Waypoint49").transform;
            waypoints[19] = GameObject.Find("Waypoint48").transform;
            waypoints[20] = GameObject.Find("Waypoint47").transform;
            waypoints[21] = GameObject.Find("Waypoint41").transform;
            waypoints[22] = GameObject.Find("Waypoint12").transform;
            waypoints[23] = GameObject.Find("Waypoint13").transform;
            waypoints[24] = GameObject.Find("Waypoint28").transform;
            waypoints[25] = GameObject.Find("Waypoint29").transform;
            waypoints[26] = GameObject.Find("Waypoint30").transform;
            waypoints[27] = GameObject.Find("Waypoint31").transform;
            waypoints[28] = GameObject.Find("Waypoint65").transform;
            waypoints[29] = GameObject.Find("Waypoint67").transform;
            waypoints[30] = GameObject.Find("Waypoint68").transform;
            waypoints[31] = GameObject.Find("Waypoint71").transform;
            waypoints[32] = GameObject.Find("Waypoint62").transform;
            waypoints[33] = GameObject.Find("Waypoint61").transform;
            waypoints[34] = GameObject.Find("Waypoint51").transform;
            waypoints[35] = GameObject.Find("Waypoint52").transform;
            waypoints[36] = GameObject.Find("Waypoint43").transform;
            waypoints[37] = GameObject.Find("Waypoint44").transform;
            waypoints[38] = GameObject.Find("Waypoint82").transform;
            waypoints[39] = GameObject.Find("Waypoint78").transform;
            waypoints[40] = GameObject.Find("Waypoint26").transform;
            waypoints[41] = GameObject.Find("Waypoint24").transform;
            waypoints[42] = GameObject.Find("Waypoint20").transform;
            waypoints[43] = GameObject.Find("Waypoint21").transform;
            waypoints[44] = GameObject.Find("Waypoint06").transform;
            waypoints[45] = GameObject.Find("Waypoint07").transform;
            waypoints[46] = GameObject.Find("Waypoint33").transform;
            waypoints[47] = GameObject.Find("Waypoint34").transform;
            waypoints[48] = GameObject.Find("Waypoint35").transform;
            waypoints[49] = GameObject.Find("Waypoint36").transform;
            waypoints[50] = GameObject.Find("Waypoint79").transform;
            waypoints[51] = GameObject.Find("Waypoint46").transform;
            waypoints[52] = GameObject.Find("Waypoint50").transform;
            waypoints[53] = GameObject.Find("Waypoint51").transform;
            waypoints[54] = GameObject.Find("Waypoint61").transform;
            waypoints[55] = GameObject.Find("Waypoint62").transform;
            waypoints[56] = GameObject.Find("Waypoint71").transform;
            waypoints[57] = GameObject.Find("Waypoint70").transform;
            waypoints[58] = GameObject.Find("Waypoint63").transform;
            waypoints[59] = GameObject.Find("Waypoint64").transform;
            waypoints[60] = GameObject.Find("Waypoint54").transform;
            waypoints[61] = GameObject.Find("Waypoint53").transform;
            waypoints[62] = GameObject.Find("Waypoint42").transform;
            waypoints[63] = GameObject.Find("Waypoint44").transform;
            waypoints[64] = GameObject.Find("Waypoint25").transform;


			
		}

		
		if (this.gameObject.name == "pinky(Clone)") {
			waypoints = new Transform[52];
			Debug.Log("pinky ");
            waypoints[0] = GameObject.Find("Waypoint88").transform;
            waypoints[1] = GameObject.Find("Waypoint27").transform;
            waypoints[2] = GameObject.Find("Waypoint04").transform;
            waypoints[3] = GameObject.Find("Waypoint05").transform;
            waypoints[4] = GameObject.Find("Waypoint15").transform;
            waypoints[5] = GameObject.Find("Waypoint17").transform;
            waypoints[6] = GameObject.Find("Waypoint81").transform;
            waypoints[7] = GameObject.Find("Waypoint80").transform;
            waypoints[8] = GameObject.Find("Waypoint02").transform;
            waypoints[9] = GameObject.Find("Waypoint00").transform;
            waypoints[10] = GameObject.Find("Waypoint06").transform;
            waypoints[11] = GameObject.Find("Waypoint07").transform;
            waypoints[12] = GameObject.Find("Waypoint24").transform;
            waypoints[13] = GameObject.Find("Waypoint26").transform;
            waypoints[14] = GameObject.Find("Waypoint45").transform;
            waypoints[15] = GameObject.Find("Waypoint46").transform;
            waypoints[16] = GameObject.Find("Waypoint50").transform;
            waypoints[17] = GameObject.Find("Waypoint52").transform;
            waypoints[18] = GameObject.Find("Waypoint43").transform;
            waypoints[19] = GameObject.Find("Waypoint42").transform;
            waypoints[20] = GameObject.Find("Waypoint53").transform;
            waypoints[21] = GameObject.Find("Waypoint54").transform;
            waypoints[22] = GameObject.Find("Waypoint64").transform;
            waypoints[23] = GameObject.Find("Waypoint63").transform;
            waypoints[24] = GameObject.Find("Waypoint70").transform;
            waypoints[25] = GameObject.Find("Waypoint72").transform;
            waypoints[26] = GameObject.Find("Waypoint60").transform;
            waypoints[27] = GameObject.Find("Waypoint58").transform;
            waypoints[28] = GameObject.Find("Waypoint73").transform;
            waypoints[29] = GameObject.Find("Waypoint72").transform;
            waypoints[30] = GameObject.Find("Waypoint46").transform;
            waypoints[31] = GameObject.Find("Waypoint42").transform;
            waypoints[32] = GameObject.Find("Waypoint53").transform;
            waypoints[33] = GameObject.Find("Waypoint55").transform;
            waypoints[34] = GameObject.Find("Waypoint41").transform;
            waypoints[35] = GameObject.Find("Waypoint39").transform;
            waypoints[36] = GameObject.Find("Waypoint38").transform;
            waypoints[37] = GameObject.Find("Waypoint37").transform;
            waypoints[38] = GameObject.Find("Waypoint29").transform;
            waypoints[39] = GameObject.Find("Waypoint28").transform;
            waypoints[40] = GameObject.Find("Waypoint13").transform;
            waypoints[41] = GameObject.Find("Waypoint12").transform;
            waypoints[42] = GameObject.Find("Waypoint04").transform;
            waypoints[43] = GameObject.Find("Waypoint05").transform;
            waypoints[44] = GameObject.Find("Waypoint05").transform;
            waypoints[45] = GameObject.Find("Waypoint15").transform;
            waypoints[46] = GameObject.Find("Waypoint17").transform;
            waypoints[47] = GameObject.Find("Waypoint81").transform;
            waypoints[48] = GameObject.Find("Waypoint80").transform;
            waypoints[49] = GameObject.Find("Waypoint18").transform;
            waypoints[50] = GameObject.Find("Waypoint20").transform;
            waypoints[51] = GameObject.Find("Waypoint24").transform;
			
		}
		
	}
	
	
	int wayPointsSize = 2;    
	int index = 0;
	
	
	public float speed = 0.3f;
	
	void FixedUpdate()
	{
		if  ((transform.position.x - waypoints[index].position.x > 0.01 || transform.position.x - waypoints[index].position.x <-0.01) ||
		     (transform.position.y - waypoints[index].position.y > 0.01 || transform.position.y - waypoints[index].position.y < -0.01))
			
		{
			Vector2 p = Vector2.MoveTowards(transform.position,
			                                waypoints[index].position,
			                                speed);
			rb.MovePosition(p);
		}
		else index = (index + 1) % waypoints.Length;
		// Animation
		Vector2 dir = waypoints[index].position - transform.position;
		animator.SetFloat("DirX", dir.x);
		animator.SetFloat("DirY", dir.y);	 // po zrobieniu animacji
	}
	void OnTriggerEnter2D(Collider2D co)
	{
		if (co.tag == "PacMan") {

            Destroy(co.gameObject);

            podejscia = podejscia - 1;

            if (podejscia == 0)
            {
                //LastScene.myLastScene = Application.loadedLevelName;
                //Application.LoadLevel("Credits");

                SceneManager.LoadScene("umrzyj");
            }
            else if (podejscia == 1)
            {
                //LastScene.myLastScene = Application.loadedLevelName;
                //Application.LoadLevel("smierc");
				int pacdotsLeftCount = GameObject.FindGameObjectsWithTag("pacdot").Length;

				if (countDots.currentScore < countDots.allPacdotsCount /2)
                    SceneManager.LoadScene("powtorka");
                else 
                    SceneManager.LoadScene("umrzyj");	// zaliczyles
                    
            }

        }
    }
}

