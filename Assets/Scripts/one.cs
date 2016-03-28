using UnityEngine;
using System.Collections;

public class one : MonoBehaviour {
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
		
		if(year== 1930 && DataManager.currentDataset.Equals("race"))
			iTween.MoveTo(GameObject.Find("man1"), iTween.Hash("path", iTweenPath.GetPath("one40"), "time", 30));
        if (transform.position.x> -37.709)
			anim.SetBool("walkstate",true);
		
		if(transform.position.x> -25 && transform.position.x< -24){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
		}
		
		if(year ==1940 && DataManager.currentDataset.Equals("race") ){
			
			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("one50"), "time", 60));
		}
		
		
		if(year == 1950 && transform.position.x > -24.159)
			anim.SetBool("walkstate",true);
		
		if(transform.position.x> -12.3){
			anim.SetTrigger("stop");
			anim.SetBool("walkstate",false);
		}
	}
}