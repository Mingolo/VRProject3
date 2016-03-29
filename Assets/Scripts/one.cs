using UnityEngine;
using System.Collections;

public class one : MonoBehaviour {
	int year;
	int flag=0;
	Animator anim;
    int walkHash = Animator.StringToHash("walkstate");
	public bool man1trig1940=false;
	void Start(){
		DataManager dm=new DataManager();
		anim=GetComponent<Animator>();
		anim.SetBool("walkstate",false);
		
	}
	void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.CompareTag("g21940"))
			{
				other.gameObject.SetActive (false);
				man1trig1940 = true;
			}
		}
			
	void Update(){
		year=DataManager.currentDecade;
		
		//if(year== 1930 && DataManager.currentDataset.Equals("race"))
			//iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        
		
		
		//if(transform.position.x> -25 && transform.position.x< -24){
			//anim.SetTrigger("stop");
			//anim.SetBool("walkstate",false);
		//}
		
		if(year ==1940 && DataManager.currentDataset.Equals("race") ){
			//GameObject.Find("aaman1").SetActive(true);
			//iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("path", iTweenPath.GetPath("two"), "time", 60));
		}
		
		
		if(year == 1950 && transform.position.x > -24.159){
			anim.SetBool("walkstate",true);
		}
		if(transform.position.x> -12.3){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
			//var man1=Instantiate(gameObject);
			//gameObject.active=false;
		}
	}
}