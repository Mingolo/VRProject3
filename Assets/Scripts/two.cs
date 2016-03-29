using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
public class two : MonoBehaviour {
	int year;
	public Dictionary<string,double> coor;
	/*coor["man11930s"]
	coor["man11940s"]
	coor["man11950s"]
	coor["man11960s"]
	coor["man11970s"]
	coor["man11980s"]
	coor["man11990s"]
	coor["man12000s"]
	coor["man12010s"]
	coor["man21930r"]
	coor["man21940r"]
	coor["man21950r"]
	coor["man21960r"]
	coor["man21970r"]
	coor["man21980r"]
	coor["man21990r"]
	coor["man22000r"]
	coor["man22010r"]
	coor["man21930s"]
	coor["man21940s"]
	coor["man21950s"]
	coor["man21960s"]
	coor["man21970s"]
	coor["man21980s"]
	coor["man21990s"]
	coor["man22000s"]
	coor["man22010s"]
	*/		
	Animator anim;
	Animator anim2;
	int flag=-1;
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
		coor = new Dictionary<string,double>();
		coor.Add("man11930r",-37.71);
		coor.Add("man11940r",-24.15);
		coor.Add("man11950r",-12.5);
		coor.Add("man11960r",70.0);
		coor.Add("man11970r",48.9);
		coor.Add("man11980r",70.0);
		coor.Add("man11990r",175.0);
		coor.Add("man12000r",175.0);
		coor.Add("man12010r",175.0);
		coor.Add("man11930s",-12.5);
		coor.Add("man11940s",-12.5);
		coor.Add("man11950s",-12.5);
		coor.Add("man11960s",70.0);
		coor.Add("man11970s",48.9);
		coor.Add("man11980s",70.0);
		coor.Add("man11990s",175.0);
		coor.Add("man12000s",175.0);
		coor.Add("man12010s",175.0);
				
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
		if(year== 1930 && DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,270,0);
			//iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        	iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11930r"], "time", 30));
			//gobj1.transform.rotation = Quaternion.Euler(0,0,0);
			flag=0;
		}
		if(year== 1940 && DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			//iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        	iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11940r"], "time", 30));
			anim.SetBool("walkstate",true);
			flag=1;
		}
			
		if(GameObject.Find("man1").GetComponent<one>().man1trig1940==true){
			//anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
			//if(flag==-1){
			//Instantiate(GameObject.Find("man1"));
			//GameObject.Find("man1").active=false;
			//GameObject.Find("man1(Clone)").name="man11";
			//flag=1;
			//}
		}
		if(year ==1950 && DataManager.currentDataset.Equals("race") &&flag==1){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11950r"], "time", 30));
			anim.SetBool("walkstate",true);
			flag=2;
			
		}	
		if(year ==1960 && flag==2){
			//anim.SetTrigger("stop");
			//anim.SetBool("walkstate",false);
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
			flag=3;
		}
		if(year==1970 && DataManager.currentDataset.Equals("race")&& flag==3){
			gobj1.transform.rotation = Quaternion.Euler(0,270,0);
			gobj2.transform.rotation = Quaternion.Euler(0,270,0);
			iTween.MoveBy(GameObject.Find("man1"), iTween.Hash("z", 20, "time", 30));
			iTween.MoveBy(GameObject.Find("man2"), iTween.Hash("z", 10, "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			flag=4;
		}
		if(year==1980 && DataManager.currentDataset.Equals("race")&& flag==4){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			iTween.MoveBy(GameObject.Find("man1"), iTween.Hash("z", 20, "time", 30));
			iTween.MoveBy(GameObject.Find("man2"), iTween.Hash("z", 10, "time", 30));
			anim.SetBool("walkstate",true);
			flag=5;
		}
		
		if(year ==1990 && flag==5){
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
			flag=6;
		}
		/*	anim.SetBool("walkstate",true);
		if(transform.position.x> -25){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
		}*/
	}
}