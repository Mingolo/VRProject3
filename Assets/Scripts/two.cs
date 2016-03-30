using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
using System;
public class two : MonoBehaviour {
	int year;
	int entered;
	string activeman;
	public int t=0;
	public int t1=0;
	public Dictionary<string,float> coor;
	Animator anim;
	Animator anim2;
	Animator anim3;
	Animator anim4;
	Animator anim5;
	Animator anim6;
	Animator anim7;
	Animator anim8;
	Animator anim9;
	Animator anim10;
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
	GameObject gobj11;
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
		coor.Add("manx1990x",152.0f);
		coor.Add("man31930r",-45.48f);
		coor.Add("man41930r",-38.68f);
		coor.Add("man51930r",-44.34f);
		coor.Add("man61930r",-43.3f);
		coor.Add("man71930r",-42.22f);
		coor.Add("man81930r",-44.69f);
		coor.Add("man91930r",-41.58f);
		coor.Add("man101930r",-40.66f);
		coor.Add("man31960r",41.0f);
		coor.Add("man41960r",47.2f);
		coor.Add("man51960r",42.0f);
		coor.Add("man61960r",44.0f);
		coor.Add("man71960r",45.0f);
		coor.Add("man81960r",42.0f);
		coor.Add("man91960r",45.0f);
		coor.Add("man101960r",46.0f);
		coor.Add("man31990r",151.0f);
		coor.Add("man41990r",157.2f);
		coor.Add("man51990r",152.0f);
		coor.Add("man61990r",154.0f);
		coor.Add("man71990r",155.0f);
		coor.Add("man81990r",152.0f);
		coor.Add("man91990r",155.0f);
		coor.Add("man101990r",156.0f);
				
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
		gobj11=GameObject.Find("man11");
		anim=GameObject.Find("man1").GetComponent<Animator>();
		anim2=GetComponent<Animator>();
		DataManager dm=new DataManager();
		anim.SetBool("walkstate",false);
		PredictionManager pm= new PredictionManager();
		anim=GameObject.Find("man1").GetComponent<Animator>();
		anim2=GameObject.Find("man2").GetComponent<Animator>();
		anim3=GameObject.Find("man3").GetComponent<Animator>();
		anim4=GameObject.Find("man4").GetComponent<Animator>();
		anim5=GameObject.Find("man5").GetComponent<Animator>();
		anim6=GameObject.Find("man6").GetComponent<Animator>();
		anim7=GameObject.Find("man7").GetComponent<Animator>();
		anim8=GameObject.Find("man8").GetComponent<Animator>();
		anim9=GameObject.Find("man9").GetComponent<Animator>();
		anim10=GameObject.Find("man10").GetComponent<Animator>();
		
	}
		
	void Update(){
		year=DataManager.currentDecade;
		if(year== 1930 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11930r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21930r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			if(gobj2.transform.position.x > 37.709f)
				anim2.SetBool("walkstate",true);
			if(gobj1.transform.position.x > 37.709f)
				anim.SetBool("walkstate",true);
			if(gobj2.transform.position.x < 37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x < 37.0f)
				anim.SetBool("walkstate",false);
		
		}
		
		if(year== 1930 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11930s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21930s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x> -26.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -14.0f)
				anim.SetBool("walkstate",false);
		
		}
		if(year== 1940 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11940r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21940r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -25.3f && gobj1.transform.position.x< -22.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year== 1940 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11940s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21940s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -14.3f)
				anim.SetBool("walkstate",false);
			
		}
			
		if(GameObject.Find("man1").GetComponent<one>().man1trig1940==true){
			gobj11.transform.position=new Vector3(-24.18f, 0.0f, -73.2f);
			gobj1.transform.position=new Vector3(-24.15f, -25.0f, -73.2f);
			//activeman="man11";	
		}
		if(year ==1950 && DataManager.currentDataset.Equals("race")){
			//gobj1.transform.position=new Vector3(-24.15f, 0.0f, -73.2f);
			//gobj11.transform.position=new Vector3(-24.15f, -25.0f, -73.2f);
			iTween.MoveTo(gobj1, iTween.Hash("x", coor["man11950r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			//gobj1.transform.position = Vector3.Lerp(gobj1.transform.position, Vector3(-12.5f, 0.0f, -73.2f), 1.0f);
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21950r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			//anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			gobj3.transform.position = new Vector3(coor["man31930r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41930r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51930r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61930r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71930r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81930r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91930r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101930r"]+0.0f, 0.0f, -67.82f);
			
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -14.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year ==1950 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11950s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21950s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate", true);
			gobj3.transform.position = new Vector3(coor["man31930r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41930r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51930r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61930r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71930r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81930r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91930r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101930r"]+0.0f, 0.0f, -67.82f);
			
			if(gobj2.transform.position.x< -37.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> -14.3f)
				anim.SetBool("walkstate",false);
			
		}		
		if(year ==1960 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11960r"], "time", 5,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21960r"], "time", 5,"eastype", iTween.EaseType.linear, "orienttopath", true));
			gobj3.transform.position = new Vector3(coor["man31960r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41960r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51960r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61960r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71960r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81960r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91960r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101960r"]+0.0f, 0.0f, -67.82f);
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year ==1960 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11960s"], "time", 12,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21960s"], "time", 12,"eastype", iTween.EaseType.linear, "orienttopath", true));
			gobj3.transform.position = new Vector3(coor["man31960r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41960r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51960r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61960r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71960r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81960r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91960r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101960r"]+0.0f, 0.0f, -67.82f);
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		
		if(year==1970 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11970r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21970r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x< 50.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x< 50.0f)
				anim.SetBool("walkstate",false);
			}
		if(year==1970 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11970s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21970s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year==1980 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11980r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21980r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			gobj3.transform.position = new Vector3(coor["man31960r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41960r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51960r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61960r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71960r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81960r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91960r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101960r"]+0.0f, 0.0f, -67.82f);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year==1980 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11980s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21980s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			gobj3.transform.position = new Vector3(coor["man31960r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41960r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51960r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61960r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71960r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81960r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91960r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101960r"]+0.0f, 0.0f, -67.82f);
			if(gobj2.transform.position.x> 57.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 69.0f)
				anim.SetBool("walkstate",false);
			
		}
		
		if(year ==1990 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11990r"], "time", 5,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21990r"], "time", 5,"eastype", iTween.EaseType.linear, "orienttopath", true));
			gobj3.transform.position = new Vector3(coor["man31990r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41990r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51990r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61990r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71990r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81990r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91990r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101990r"]+0.0f, 0.0f, -67.82f);
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 164.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 174.0f)
				anim.SetBool("walkstate",false);
		}
		if(year ==1990 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man11990s"], "time", 5,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man21990s"], "time", 5,"eastype", iTween.EaseType.linear, "orienttopath", true));
			gobj3.transform.position = new Vector3(coor["man31990r"]+0.0f, 0.0f, -72.54f);
			gobj4.transform.position = new Vector3(coor["man41990r"]+0.0f, 0.0f, -70.99f);
			gobj5.transform.position = new Vector3(coor["man51990r"]+0.0f, 0.0f, -71.27f);
			gobj6.transform.position = new Vector3(coor["man61990r"]+0.0f, 0.0f, -69.66f);
			gobj7.transform.position = new Vector3(coor["man71990r"]+0.0f, 0.0f, -68.48f);
			gobj8.transform.position = new Vector3(coor["man81990r"]+0.0f, 0.0f, -74.82f);
			gobj9.transform.position = new Vector3(coor["man91990r"]+0.0f, 0.0f, -70.99f);
			gobj10.transform.position = new Vector3(coor["man101990r"]+0.0f, 0.0f, -67.82f);
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 164.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 174.0f)
				anim.SetBool("walkstate",false);
		}
		if(year==2000 && DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man12000r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man22000r"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x> 164.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 174.0f)
				anim.SetBool("walkstate",false);
			
		}
		if(year==2000 && !DataManager.currentDataset.Equals("race")){
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("x", coor["man12000s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("x", coor["man22000s"], "time", 20,"eastype", iTween.EaseType.linear, "orienttopath", true));
			anim.SetBool("walkstate",true);
			anim2.SetBool("walkstate",true);
			if(gobj2.transform.position.x< 156.0f)
				anim2.SetBool("walkstate",false);
			if(gobj1.transform.position.x> 174.0f)
				anim.SetBool("walkstate",false);
		}
		
		if(year==2010){
			int w=0,b=0,o=0,ht=0,ho=0,bi=0;
			entered=PredictionManager.workingOnPredictions;
			gobj1.transform.position = new Vector3(coor["man11960r"]+0.0f, 0.0f, -73.2f);
			gobj2.transform.position = new Vector3(coor["man21960r"]+0.0f, 0.0f, -69.2f);
			gobj3.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -67.2f);
			gobj4.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -75.2f);
			gobj5.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -65.2f);
			gobj6.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -70.2f);
			gobj7.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -72.2f);
			gobj8.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -66.2f);
			gobj9.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -68.2f);
			gobj10.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -71.2f);
			
			if(entered==2 && flag==0){
				flag=1;
				w=GameObject.Find("PredictionUI").GetComponent<PredictionManager>().predictedData[0];
				b=GameObject.Find("PredictionUI").GetComponent<PredictionManager>().predictedData[1];
				o=GameObject.Find("PredictionUI").GetComponent<PredictionManager>().predictedData[2];
				ht=GameObject.Find("PredictionUI").GetComponent<PredictionManager>().predictedData[3];
				ho=GameObject.Find("PredictionUI").GetComponent<PredictionManager>().predictedData[4];
				bi=GameObject.Find("PredictionUI").GetComponent<PredictionManager>().predictedData[5];
				t=w+b+o;
				t1=ht+ho+bi;
				for(int i=0;i<w;i++){
					Instantiate(GameObject.Find("man1"), new Vector3(i + 151.0f, 0.0f, -73.0f), Quaternion.identity);
					
				}
				for(int i=0;i<b;i++){
					Instantiate(GameObject.Find("man1"), new Vector3(i + 162.0f, 0.0f, -73.0f), Quaternion.identity);
					
				}
				for(int i=0;i<o;i++){
					Instantiate(GameObject.Find("man1"), new Vector3(i + 173.0f, 0.0f, -73.0f), Quaternion.identity);
					
				}
				/*GameObject[] killEmAll;
				killEmAll = GameObject.FindGameObjectsWithTag("clone");
				for(int i = 0; i < killEmAll.Length; i++)
				{
					Destroy(killEmAll[i].gameObject,20);
				}*/
				Invoke ("killClones", 20);

			}
			if(entered==3 && flag==1)
			{	
				for(int i=0;i<w+b+o;i++)
					GameObject.Destroy( GameObject.Find("man1(Clone)"));
				
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

				flag=2;
			}
			if(entered==4 && flag==2){
				gobj1.transform.position = new Vector3(coor["man11960r"]+0.0f, 0.0f, -73.2f);
				gobj2.transform.position = new Vector3(coor["man21960r"]+0.0f, 0.0f, -69.2f);
				gobj3.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -67.2f);
				gobj4.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -75.2f);
				gobj5.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -65.2f);
				gobj6.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -70.2f);
				gobj7.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -72.2f);
				gobj8.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -66.2f);
				gobj9.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -68.2f);
				gobj10.transform.position = new Vector3(coor["manx1960x"]+0.0f, 0.0f, -71.2f);
				flag=3;
				
				for(int i=0;i<ht;i++){
					Instantiate(GameObject.Find("man1"), new Vector3(i + 151.0f, 0.0f, -73.0f), Quaternion.identity);
				}
				for(int i=0;i<ho;i++){
					Instantiate(GameObject.Find("man1"), new Vector3(i + 162.0f, 0.0f, -73.0f), Quaternion.identity);
				}
				for(int i=0;i<bi;i++){
					Instantiate(GameObject.Find("man1"), new Vector3(i + 173.0f, 0.0f, -73.0f), Quaternion.identity);
				}
			}
			if(entered==5 && flag==3)
			{
				for(int i=0;i<ht+ho+bi;i++)
					Destroy( GameObject.Find("man1(Clone)"));
				
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
				flag=-1;
			}
		}
		
	}
	void killClones(){
		for(int i=0;i<t;i++){
			Destroy(GameObject.Find("man1(Clone)"));
			GameObject.Find("man1(Clone)").transform.position = new Vector3(coor["man11990r"]+0.0f, -30.0f, -73.2f);
		}
		GameObject.Find("man1").transform.position = new Vector3(coor["man11990r"]+0.0f, 0.0f, -73.2f);
		GameObject.Find("man2").transform.position = new Vector3(coor["man21990r"]+0.0f, 0.0f, -69.2f);
		GameObject.Find("man3").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -67.2f);
		GameObject.Find("man4").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -75.2f);
		GameObject.Find("man5").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -65.2f);
		GameObject.Find("man6").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -70.2f);
		GameObject.Find("man7").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -72.2f);
		GameObject.Find("man8").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -66.2f);
		GameObject.Find("man9").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -68.2f);
		GameObject.Find("man10").transform.position = new Vector3(coor["manx1990x"]+0.0f, 0.0f, -71.2f);
	}
	void killClones2(){
		for(int i=0;i<t1;i++)
					Destroy( GameObject.Find("man1(Clone)"));			
	}
}