using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
public class two : MonoBehaviour {
	int year;
	public Dictionary<string,float> coor;
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
		coor = new Dictionary<string,float>();
		coor.Add("man11930r",-37.71f);
		coor.Add("man11940r",-24.15f);
		coor.Add("man11950r",-12.5f);
		coor.Add("man11960r",70.0f);
		coor.Add("man11970r",48.9f);
		coor.Add("man11980r",70.0f);
		coor.Add("man11990r",175.0f);
		coor.Add("man12000r",175.0f);
		coor.Add("man12010r",175.0f);
		coor.Add("man11930s",-12.5f);
		coor.Add("man11940s",-12.5f);
		coor.Add("man11950s",-12.5f);
		coor.Add("man11960s",70.0f);
		coor.Add("man11970s",70.0f);
		coor.Add("man11980s",70.0f);
		coor.Add("man11990s",175.0f);
		coor.Add("man12000s",175.0f);
		coor.Add("man12010s",175.0f);
		coor.Add("man21930r",-37.71f);
		coor.Add("man21940r",-37.71f);
		coor.Add("man21950r",-37.71f);
		coor.Add("man21960r",58.0f);
		coor.Add("man21970r",48.9f);
		coor.Add("man21980r",58.0f);
		coor.Add("man21990r",165.0f);
		coor.Add("man22000r",165.0f);
		coor.Add("man22010r",165.0f);
		coor.Add("man21930s",-24.15f);
		coor.Add("man21940s",-37.71f);
		coor.Add("man21950s",-37.71f);
		coor.Add("man21960s",58.0f);
		coor.Add("man21970s",58.0f);
		coor.Add("man21980s",58.0f);
		coor.Add("man21990s",165.0f);
		coor.Add("man22000s",155.0f);
		coor.Add("man22010s",175.0f);
		coor.Add("manx1960x", 48.0f);
		coor.Add("manx1990x",155.0f);		
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
			gobj2.transform.rotation = Quaternion.Euler(0,270,0);
			//iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        	iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11930r"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21930r"], "time", 30));
			//gobj1.transform.rotation = Quaternion.Euler(0,0,0);
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x > coor["man21930r"])
				anim2.SetBool("walkstate",true);
			if(gobj1.transform.position.x > coor["man11930r"])
				anim.SetBool("walkstate",true);
		
		}
		
		if(year== 1930 && !DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			//iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        	iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11930s"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21930s"], "time", 30));
			//gobj1.transform.rotation = Quaternion.Euler(0,0,0);
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x> -24.3f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -13f)
				anim.SetBool("walkstate",false);
		
		}
		if(year== 1940 && DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			//iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        	iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11940r"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21940r"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -24.3f)
				anim.SetBool("walkstate",false);
			
		}
		if(year== 1940 && !DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,270,0);
			//iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        	iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11940s"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21940s"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -24.3f)
				anim.SetBool("walkstate",false);
			
		}
			
		if(GameObject.Find("man1").GetComponent<one>().man1trig1940==true){
			//anim.SetTrigger("stop");
			//anim.SetBool("walkstate",false);
			//if(flag==-1){
			//Instantiate(GameObject.Find("man1"));
			//GameObject.Find("man1").active=false;
			//GameObject.Find("man1(Clone)").name="man11";
			//flag=1;
			//}
		}
		if(year ==1950 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11950r"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21950r"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -24.3f)
				anim.SetBool("walkstate",false);
			
		}
		if(year ==1950 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11950s"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21950s"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -24.3f)
				anim.SetBool("walkstate",false);
			
		}		
		if(year ==1960 && DataManager.currentDataset.Equals("race")){
			//anim.SetTrigger("stop");
			//anim.SetBool("walkstate",false);
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11960r"], "time", 15));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21960r"], "time", 15));
			iTween.MoveTo(GameObject.Find("man3"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man4"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man5"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man6"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man7"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man8"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man9"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man10"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			
		}
		if(year ==1960 && !DataManager.currentDataset.Equals("race")){
			//anim.SetTrigger("stop");
			//anim.SetBool("walkstate",false);
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11960s"], "time", 15));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21960s"], "time", 15));
			iTween.MoveTo(GameObject.Find("man3"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man4"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man5"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man6"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man7"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man8"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man9"), iTween.Hash("x", coor["manx1960x"], "time", 15));
			iTween.MoveTo(GameObject.Find("man10"), iTween.Hash("x", coor["manx1960x"], "time", 15));
		}
		
		if(year==1970 && DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,270,0);
			gobj2.transform.rotation = Quaternion.Euler(0,270,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11970r"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21970r"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x< 49.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x< 49.0f)
				anim.SetBool("walkstate",false);
			}
		if(year==1970 && !DataManager.currentDataset.Equals("race")){
			//gobj1.transform.rotation = Quaternion.Euler(0,270,0);
			//gobj2.transform.rotation = Quaternion.Euler(0,270,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11970s"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21970s"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year==1980 && DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11980r"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21980r"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year==1980 && !DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11980s"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21980s"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		
		if(year ==1990 && DataManager.currentDataset.Equals("race") ){
			gobj1.transform.position = new Vector3(coor["man11990r"]+0.0f, 0.0f, -73.2f);
			gobj2.transform.position = new Vector3(coor["man21990r"]+0.0f, 0.0f, -69.2f);
			gobj3.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -67.2f);
			gobj4.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -75.2f);
			gobj5.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -65.2f);
			gobj6.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -70.2f);
			gobj7.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -72.2f);
			gobj8.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -66.2f);
			gobj9.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -68.2f);
			gobj10.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -71.2f);
		}
		if(year ==1990 && !DataManager.currentDataset.Equals("race") ){
			gobj1.transform.position = new Vector3(coor["man11990s"]+0.0f, 0.0f, -73.2f);
			gobj2.transform.position = new Vector3(coor["man21990s"]+0.0f, 0.0f, -69.2f);
			gobj3.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -67.2f);
			gobj4.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -75.2f);
			gobj5.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -65.2f);
			gobj6.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -70.2f);
			gobj7.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -72.2f);
			gobj8.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -66.2f);
			gobj9.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -68.2f);
			gobj10.transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -71.2f);
		}
		/*	anim.SetBool("walkstate",true);
		if(transform.position.x> -25){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
		}*/
		if(year==2000 && DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,90,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man12000r"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man22000r"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 164.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 174.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year==2000 && !DataManager.currentDataset.Equals("race")){
			gobj1.transform.rotation = Quaternion.Euler(0,90,0);
			gobj2.transform.rotation = Quaternion.Euler(0,270,0);
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man12000s"], "time", 30));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man22000s"], "time", 30));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x< 156.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 174.0f)
				anim.SetBool("walkstate",false);
		}
	}
}