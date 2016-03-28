using UnityEngine;
using System.Collections;

public class two : MonoBehaviour {
	int year;
	Animator anim;
    int walkHash = Animator.StringToHash("walkstate");

	void Start(){
		DataManager dm=new DataManager();
		anim=GetComponent<Animator>();
		anim.SetBool("walkstate",false);
	}
		
	void Update(){
		year=DataManager.currentDecade;
		/*if (year== 1930)
			iTween.MoveTo(GameObject.Find("man2"), iTween.Hash("path", iTweenPath.GetPath("two"), "time", 30));
        if(year ==1940)
			anim.SetBool("walkstate",true);
		if(transform.position.x> -25){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
		}*/
	}
}