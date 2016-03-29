using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;

public class one : MonoBehaviour {
	int year;
	int flag=0;
	//Animator anim;
    int walkHash = Animator.StringToHash("walkstate");
	public bool man1trig1940=false;
	void Start(){
		DataManager dm=new DataManager();
		//anim=GetComponent<Animator>();
		//anim.SetBool("walkstate",false);
		
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
		//year=DataManager.currentDecade;
		/*if(transform.position > GameObject.Find("man2").GetComponent<two>().coor['man11930r'])
			anim.SetBool("walkstate",true);
		
		if(transform.position>GameObject.Find("man2").GetComponent<two>().coor['man11940r'])
			anim.SetBool("walkstate",true);
		
		if(transform.position>GameObject.Find("man2").GetComponent<two>().coor['man11950r'])
			anim.SetBool("walkstate",true);
		
		if(transform.position<GameObject.Find("man2").GetComponent<two>().coor['man11960r'])
			anim.SetBool("walkstate",true);
		if(transform.position>GameObject.Find("man2").GetComponent<two>().coor['man11970r'])
			anim.SetBool("walkstate",true);
		if(transform.position>GameObject.Find("man2").GetComponent<two>().coor['man11980r'])
			anim.SetBool("walkstate",true);
		if(transform.position>GameObject.Find("man2").GetComponent<two>().coor['man11990r'])
			anim.SetBool("walkstate",true);
		if(transform.position>GameObject.Find("man2").GetComponent<two>().coor['man12000r'])
			anim.SetBool("walkstate",true);
		*/
		//if(transform.position.x> -25 && transform.position.x< -24){
			//anim.SetTrigger("stop");
			//anim.SetBool("walkstate",false);
		//}
		
		if(year ==1940 && DataManager.currentDataset.Equals("race") ){
			//GameObject.Find("aaman1").SetActive(true);
			//iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("path", iTweenPath.GetPath("two"), "time", 60));
		}
		
		
		if(year == 1950 && transform.position.x > -24.159){
			//anim.SetBool("walkstate",true);
		}
		
	}
}