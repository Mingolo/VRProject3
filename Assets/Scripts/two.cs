using UnityEngine;
using System.Collections;

public class two : MonoBehaviour {
	int year;
	Animator anim;
	Animator anim2;
	int flag=0;
    int walkHash = Animator.StringToHash("walkstate");
	GameObject gobj1;
	GameObject gobj2;
	GameObject gobj3;
	GameObject gobj4;
	GameObject gobj5;
	GameObject gobj6;
	GameObject gobj7;
	GameObject gobj8;
	GameObject gobj9;
	GameObject gobj10;
	void Start(){
		gobj1=GameObject.Find("man1");
		gobj2=GameObject.Find("man2");
		gobj3=GameObject.Find("man3");
		gobj4=GameObject.Find("man4");
		gobj5=GameObject.Find("man5");
		gobj6=GameObject.Find("man6");
		gobj7=GameObject.Find("man7");
		gobj8=GameObject.Find("man8");
		gobj9=GameObject.Find("man9");
		gobj10=GameObject.Find("man10");
		anim=GameObject.Find("man1").GetComponent<Animator>();
		anim2=GetComponent<Animator>();
		DataManager dm=new DataManager();
		anim.SetBool("walkstate",false);
	}
		
	void Update(){
		year=DataManager.currentDecade;
		if(year== 1930 && DataManager.currentDataset.Equals("race"))
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        
		if (GameObject.Find("man1").transform.position.x> -37.709)
			anim.SetBool("walkstate",true);
		
			
		/*if(GameObject.Find("man1").GetComponent<one>().man1trig1940==false){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
			if(flag==0){
			Instantiate(GameObject.Find("man1"));
			GameObject.Find("man1").active=false;
			GameObject.Find("man1(Clone)").name="man11";
			flag=1;
			}
		}*/
		if(year ==1940)
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one50"), "time", 30));
		if(year == 1950 && transform.position.x > -24.159){
			anim.SetBool("walkstate",true);
		}	
		if(year ==1960 && flag==0){
			gobj1.transform.position = new Vector3(gobj1.transform.position.x+82.0f, 0.0f, -73.2f);
			gobj2.transform.position = new Vector3(gobj2.transform.position.x+95.0f, 0.0f, -73.2f);
			gobj3.transform.position = new Vector3(gobj3.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj4.transform.position = new Vector3(gobj4.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj5.transform.position = new Vector3(gobj5.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj6.transform.position = new Vector3(gobj6.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj7.transform.position = new Vector3(gobj7.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj8.transform.position = new Vector3(gobj8.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj9.transform.position = new Vector3(gobj9.transform.position.x+85.0f, 0.0f, -73.2f);
			gobj10.transform.position = new Vector3(gobj10.transform.position.x+85.0f, 0.0f, -73.2f);
			flag=1;
		}
		if(year ==1990 && flag==1){
			gobj1.transform.position = new Vector3(gobj1.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj2.transform.position = new Vector3(gobj2.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj3.transform.position = new Vector3(gobj3.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj4.transform.position = new Vector3(gobj4.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj5.transform.position = new Vector3(gobj5.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj6.transform.position = new Vector3(gobj6.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj7.transform.position = new Vector3(gobj7.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj8.transform.position = new Vector3(gobj8.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj9.transform.position = new Vector3(gobj9.transform.position.x+105.0f, 0.0f, -73.2f);
			gobj10.transform.position = new Vector3(gobj10.transform.position.x+105.0f, 0.0f, -73.2f);
			flag=2;
		}
		/*	anim.SetBool("walkstate",true);
		if(transform.position.x> -25){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
		}*/
	}
}