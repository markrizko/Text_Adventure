using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell_0, sheets_0, sheets_1, sheets_2, 
		file_0, door_0, door_1, guard_0, guard_1, freedom, yard, window, 
		file_1, cell_1, sheets_3, ladder_0, ladder_1, ladder_2, rock_0, 
		rock_1, bonus, outb_0, scaf_0, tun_0, front_0, car_0, car_1, front_fail, front_1,
		office_go, upstairs_0, front_2, front_fail_1, scaf_1, tun_1, left_0, left_1, right_0, right_1}
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell_0;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		if (myState == States.cell_0) {state_cell_0();}
		else if (myState == States.sheets_0) {state_sheets_0 ();}
		else if (myState == States.sheets_1) {state_sheets_1();}
		else if (myState == States.door_0) {door_0 ();}
		else if (myState == States.cell_1) {state_cell_1();}
		else if (myState == States.file_1) {state_file_1();}
		else if (myState == States.file_0) {state_file_0();}
		else if (myState == States.freedom) {state_freedom();}
		else if (myState == States.yard) {state_yard();}
		else if (myState == States.guard_0) {state_guard_0();}
		else if (myState == States.window){state_window();}
		else if (myState == States.sheets_2){state_sheets_2();}
		else if (myState == States.door_1){door_1();}
		else if (myState == States.sheets_3){state_sheets_3();}
		else if (myState == States.guard_1){state_guard_1();}
		else if (myState == States.ladder_0){state_ladder_0();}
		else if (myState == States.ladder_1){state_ladder_1();}
		else if (myState == States.ladder_2){state_ladder_2();}
		else if (myState == States.rock_0){state_rock_0();}
		else if (myState == States.rock_1){state_rock_1();}
		else if (myState == States.bonus) {bonus();}
		else if (myState == States.outb_0) {outb_0();}
		else if (myState == States.tun_0) {tun_0();}
		else if (myState == States.scaf_0){scaf_0();}
		else if (myState == States.front_0) {front_0();}
		else if (myState == States.car_0){car_0();}
		else if (myState == States.car_1){car_1();}
		else if (myState == States.front_fail){front_fail();}
		else if (myState == States.front_1){front_1();}
		else if (myState == States.office_go){office_go();}
		else if (myState == States.upstairs_0){upstairs_0();}
		else if (myState == States.front_2){front_2();}
		else if (myState == States.front_fail_1){front_fail_1();}
		else if (myState == States.scaf_1){scaf_1();}
		else if (myState == States.tun_1){tun_1();}
		else if (myState == States.left_0){left_0();}
		else if (myState == States.left_1){left_1();}
		else if (myState == States.right_0){right_0();}
		else if (myState == States.right_1){right_1();}
		
	}
	void state_cell_0 () {
		text.text = "It's been 34 days since the incident, seven million dollars " + 
			"embezzled and every trace of evidence points back to you. You know " +
			"you're innocent, but you have no proof. Your fingerprints were on the " +
			"keyboard on the computer that the money was stolen on. You need to escape " +
			"from prison, investigate the scene on your own and gather evidence, and break " +
			"back into prison before dawn. You're the only hope for your family. "+
			"All you have in your cell are some dirty sheets, a file, and a concrete, barred door " +
			"which seems to be locked from the outside.\n\nPress S to view the sheets, F to " + 
			"view the file, and D to view the door.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		}
		else if (Input.GetKeyDown (KeyCode.F)){
			myState = States.file_0;
		}
		else if (Input.GetKeyDown (KeyCode.D)){
			myState = States.door_0;
		}
		else if (Input.GetKeyDown(KeyCode.B)){
			myState = States.bonus;
		}
	}
	void state_sheets_0 () {
		text.text = "So disgusting that nobody bothers to clean these " +
			"sheets! They've become so toxic you could almost kill someone " +
			"with them!\n\nPress R to return to cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_0;
		}
	}
	void door_0 () {
		text.text = "The cell door is made of concrete bars, if only "+ 
			"there was a way to hack through the bars and make your way out..." +
			"\n\nPress R to return to cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_0;
		}
		
	}
	void state_sheets_1() {
		text.text = "The sheets are still there.. Just rotting like your " +
			"relationship with your ex-wife...\n\nPress R to return to cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.file_1;
		}
		
	}
	void state_cell_1() {
		text.text = "You have successfully crawled back into your cell and completed " +
			"your mission! Give yourself a pat on the back!\n\nPress P to play again!";
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell_0;
		}
	}
	void state_file_1() {
		text.text = "You have the file, but you're still stuck in this damn cell!! " +
			"There has to be some use to this file, you think as you observe the surrounding " +
			"door and sheets.\n\nPress D to go to the door. Press S to go to the sheets.";
		if (Input.GetKeyDown(KeyCode.D)){
			myState = States.door_1;
		}
		else if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_1;
		}
	}
	void state_file_0(){
		text.text = "What's this? Your cell-mate Johnny left you a little " +
			"present under your cot. Maybe this will come in handy.\n\n" +
			"Press T to take file. R to return to cell.";
		if (Input.GetKeyDown (KeyCode.T)){
			myState = States.file_1;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_0;
		}
	}
	void state_freedom(){
		text.text ="Guess it's time to break back into prison!!\n\nPress Y to get out of the car and skulk " +
			"around the prison yard.";
		if (Input.GetKeyDown(KeyCode.Y))
		{
			myState = States.yard;
		}
	}
	void state_window(){
		text.text = "You scrape the file against the window, and just like you did the door, " +
			"you create a gap just large enough for you to pass through while making the window look " +
			"completely normal from a distance.\n\nPress S to slide back into your cell. Press D to descend " +
			"from the ladder.";
		if (Input.GetKeyDown(KeyCode.D)){
			myState = States.ladder_2;
		}
		else if (Input.GetKeyDown(KeyCode.S)){
			myState = States.cell_1;
		}
	}
	void state_guard_0(){
		text.text = "You startled the guard and he's caught you trying to escape!\n\n" +
			"Press R to restart.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_0;
		}
	}
	void state_yard(){
		text.text = "Out in the yard you are blessed with a rock, a ladder, and a clear view "+
			"of your cell window above. Choose wisely.\n\nPress R to go to the rock. Press L to " +
			"go to the Ladder.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.rock_0;
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.ladder_0;
		}
	}
	void door_1(){
		text.text = "You hack away at the door for some time, and eventually " +
			"two of the bars are thin enough for you to slip through, but not " +
			"thin enough for anyone to notice. You're now standing outside your cell, " +
			"and there seems to be a guard dozing off a few feet away. Your sheets are " +
			"also still rotting away in your cell.\n\n" +
			"Press G to go to the guard. Press S to go to your sheets.";
		if (Input.GetKeyDown(KeyCode.G)){
			myState = States.guard_0;
		}
		else if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_2;
		}
		
	}
	void state_sheets_2(){
		text.text = "The caustic sheets of hell and sweat are still resting vigorously " +
			"on your cot. You think it's about time to try and put them to use.\n\n" +
			"Press T to take the sheets. Press R to return to cell.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.door_1;
		}
		else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.sheets_3;
		}
	}
	void state_sheets_3(){
		text.text = "Your only option now is to approach the guard and hope those sheets " +
			"can be of some use to you.\n\nPress G when you're ready...";
		if (Input.GetKeyDown(KeyCode.G)){
			myState = States.guard_1;
		}
	}
	void state_guard_1(){
		text.text = "You knew those sheets could be used for something, you wrap your " +
			"sheets around the guards face, silencing him and knocking him out with your " +
			"pungent body odor!\n\n C to continue.";
			
		if (Input.GetKeyDown(KeyCode.C)){
			myState = States.office_go;
		}
	}
	void state_ladder_0(){
		text.text = "You come across a flimsy industrial ladder, almost as tall as the building itself. " +
			"with a little bit of adjusting, you can position the ladder right under your window.\n\n" +
			"Press C to climb the ladder. Press R to return to the yard.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.yard;
		}
		else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.ladder_1;
		}
	}
	void state_ladder_1(){
		text.text = "You climb up the ladder to your window and pull the file out of your pocket.\n\n" +
			"Press F to file the window. Press D to descend from the ladder.";
		if (Input.GetKeyDown(KeyCode.F)){
			myState = States.window;
		}
		else if (Input.GetKeyDown(KeyCode.D)){
			myState = States.ladder_2;
		}
	}
	void state_ladder_2(){
		text.text = "As you descend from the ladder, your foot stomps down too hard on one of the " +
			"pegs, and it breaks right under you. You fall to your doom.\n\nPress R to restart.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_0;
		}
	}
	void state_rock_0(){
		text.text = "You come across a nice big rock, with a sturdy and dense structure. The window " +
			"is just close enough so that you could reach it with the rock.\n\nPress T to throw the rock " +
			"at the window. Press R to return to the yard.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.yard;
		}
		else if (Input.GetKeyDown(KeyCode.T)){
			myState = States.rock_1;
		}
	}
	void state_rock_1(){
		text.text = "You chuck the rock at the bars on the window and break two of the bars simultaneously, " +
			"making the gap in the window just big enough for you to slide in. Little did you know, the rock hitting " +
			"the window made enough noise to attract two of the officers on duty nearby. You just got busted for trying " +
			"to break back into prison.\n\nPress R to restart.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_0;
		}
	}
	void bonus(){
		text.text = "You reached the bonus screen!! Give yourself a pat on the back for pressing completely random buttons :)"+
			"\n\nPress R to return.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_0;
		}
		
	}	
	void outb_0(){
		text.text = "You roll up outside of your workplace and park the police car inside some bushes. "
			+ "You need to find a way inside now. There's a slightly creaked window on the third floor which can be reached by a nearby scaffolding, a secret underground tunnel " +
			"that may or may not trigger the alarm, and there is always the front door. "
			+"\n\nPress S to go to the scaffold, U to find the tunnel, and F to try the front door.";
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.scaf_0;
		}
		else if (Input.GetKeyDown(KeyCode.U)){
			myState = States.tun_0;
		}
		else if (Input.GetKeyDown(KeyCode.F)){
			myState = States.front_0;
		}
		
	}
		
	void scaf_0() {
		text.text = "You approach the scaffolding and it's just low enough for you to " +
			"hop into. The remote is also still functional.\n\nPress H to hop in, R to return.";
		if (Input.GetKeyDown(KeyCode.H)){
			myState = States.scaf_1;
		}
		else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.outb_0;
		}
	}
	void tun_0(){
		text.text = "You approach the tunnel, and you see the hatch is slightly open, just as you left it " +
			"before the arrest. There is a lantern behind the bush hiding the tunnel so darkness won't be a problem.\n\n" +
			"Press E to enter the tunnel. R to return.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.outb_0;
		}
		else if (Input.GetKeyDown(KeyCode.E)){
			myState = States.tun_1;
		}
	}
	void front_0(){
		text.text = "There is a security guard roaming the front door. There must be some" +
			" way to get past him.\n\nPress C to check your car for anything that would help, S " +
			"to sneak your way in, or R to return.";
		if (Input.GetKeyDown(KeyCode.C)){
			myState = States.car_0;
		}
		else if (Input.GetKeyDown(KeyCode.S)){
			myState = States.front_fail;
		}
		else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.outb_0;
		}
	}
	void car_0(){
		text.text = "You find a uniform, gun, silencer, and badge! What luck!\n\n" +
			"Press G to gear up, and R to return.";
		if (Input.GetKeyDown(KeyCode.G)){
			myState = States.car_1;
		}
		else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.front_0;
		}
	}
	void car_1(){
		text.text ="You're all geared up and ready to go.\n\n Press G to go in.";
		if (Input.GetKeyDown(KeyCode.G)){
			myState = States.front_1;
		}
	}
	void front_fail(){
		text.text = "You try to slip through the front door and past the security guard, " +
			"but he spots you out of the corner of his peripheral vision. Busted.\n\n" +
			"Press R to retry.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_0;
		}
	}
	void front_1(){
		text.text = "You walk right through the front door like you own the place. " +
			"The security guard acknowledges your disguise as a cop and asks you what business " +
			"you have here.\n\nA. Show him your badge and keep it confidential.\nB. Tell him you're " +
			"here to investigate the scene of the crime.";
		if (Input.GetKeyDown(KeyCode.A)){
			myState = States.front_2;
		}
		else if (Input.GetKeyDown(KeyCode.B)){
			myState = States.front_fail_1;
		}
	}
	void office_go(){
		text.text = "Time to go and investigate your office for more evidence to prove yourself innocent." +
			"\n\nPress P to proceed.";
		if (Input.GetKeyDown(KeyCode.P)){
			myState = States.outb_0;
		}
			
	}
	void upstairs_0(){
		
	}
	void front_2(){
		text.text = "The security guard steps down and acknowledges your power over him. " +
			"\n\nPress P to proceed to your office.";
		if (Input.GetKeyDown(KeyCode.P)){
			myState = States.upstairs_0;
		}
	}
	void front_fail_1(){
		text.text = "The security guard speculates about your interest on investigating " +
			"in the middle of the night and calls it in. Your identity gets exposed and you " +
			"are sent back to Jail. Busted.\n\nPress R to retry.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_0;
		}
	}
	void scaf_1(){
		text.text = "You press the up button on the control panel and the flimsy scaffolding " +
			"begins to rise. As you are going up, you notice the wire on the left side of the scaffolding " +
			"is chewed down. You rapidly switch the direction to down but with your weight, the scaffold " +
			"was already planning on going down. As the wire breaks you reflect on your life and see " +
			"it flash before your eyes.\n\nPress R to retry.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_0;
		}
	}
	void tun_1(){
		text.text = "As you enter the tunnel, the ladder breaks and you fall onto the ground.\nBang!\n" +
			"You give yourself a minute to get on your feet and recover before proceeding. There are two " +
			"paths to take, the left one which leads to the garbage dump, or the right one which leads to a supply closet " +
			"on the fourth floor.\n\nPress L to go left, Press R to go right.";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.right_0;
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.left_0;
		}
	}
	void left_0(){
		
	}
	void left_1(){
		
	}
	void right_0(){
		
	}
	void right_1(){
		
	}
} 