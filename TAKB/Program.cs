using System;
using System.Timers;

/*phins cheat sheat
 one = means assign, two == means check if equal to each other
*/

namespace TAKB {
	
	class MainClass {
		public static void Main (string[] args) {
//=========================INT Block============================\\

			//Multiplication Integers 
			int num01;
			int num02;
//=========================DOUBLE Block==========================\\
			//Double dev01;
			//Double dev02;
//=========================Stuff n things========================\\

		/**
		 * Beginning Dialogue stage 1
		 */
			Console.WriteLine ("I'm the all knowing-ish bot\npress space to begin your journey");

			while (true) { 
				ConsoleKeyInfo info = Console.ReadKey ();
				KeyPress keyPress = new KeyPress (info.Key);

				if (keyPress.isSpace()) {
					break;
				}
			} 

				/**
				 * Beginning Dialogue stage 2
				 */
				Console.WriteLine ("\nLets exploire my mathmatical capabilities");
				Console.Write ("First some good ol multiplying (gimme a number):");

					/**
			 		 * Converts user input |(Console.ReadLine());| ToInt32 for calculations
			 		 */

						num01 = Convert.ToInt32 (Console.ReadLine());
						
						//Getting second number 
						Console.Write ("Well I need a second one dummy: ");

						//Converting second number	
						num02 = Convert.ToInt32 (Console.ReadLine());

						//takes right answer and repeates the multiplying with num03
						Console.WriteLine ("well, " + num01 + " times " + num02 + " im pretty sure equals " + num01*num02);
						Console.Write ("\nbam arn't I so shmart?");
						Console.Write ("\nYour answer: ");

							/**
			 				 * Gets the answer (class) from the user as userReturn object
			 				 */
								Answer userReturn = new Answer (Console.ReadLine ()); 

									//Tests if object userReturn fits the isYes params and acts accordingly
									if (userReturn.isYes ()) {
									Console.WriteLine ("Thanks I've worked hard since my creation to learn things to help you!\nMoving on to my devision skills...");
									} 
								
									//Tests if object userReturn (the answer) equals the params of isUnknown meaning not a preprogrammed answer/response (so then it must be "gibberish") and acts accordingly
									else if (userReturn.isUnknown()) {
									Console.WriteLine ("Ugh your answer is not preprogrammed in my database,\nI'm not thaaat smart yet ok gimme some slack\nLets just move on to division!");
									}
								
									//else if its not fitting the isYes or isUnknown params it must be isNo then acts accordingly
									else {
									Console.WriteLine ("You know what I, the all knowing-ish bot am using fucking advanced\nlearning algarithems too mathmatize and speel everything right!\nAnyway moving on to devision...");
									}
				
									//reads if space and when true clears previous dialogue
									Console.WriteLine("Press Space to continue: ");
									while (true) { 
										ConsoleKeyInfo info = Console.ReadKey ();
										KeyPress keyPress = new KeyPress (info.Key);

										if (keyPress.isSpace()) {
										Console.Clear ();
										break;
										}
									} 
				
			// Beginning dialogue of devision block
			Console.WriteLine ("Enter a number");

										
		//public class bracket
		}

	//main class bracket
	}

//=========================Answer Class===========================\\

	/**
	 * Answer object to help me figure out what people are answering.
	 */
	class Answer
	{
		/**
		 * @var string
		 */
		private string answer;

		/**
		 * @var string
		 */
		protected string[] falseStatements = { "n", "N", "no", "No", "not", "Not", "false", "False", "negative", "Negative", "lying", "lied", "lies", "na", "Na", "nah", "Nah", "naw", "Naw", "nu", "Nu"};

				/**
		 * @var string
		 */
		protected string[] trueStatements = {"y", "Y", "yes", "Yes", "Sure", "sure", "yeah", "Yeah", "true", "True", "yep", "Yep", "yea", "Yea", "dope", "Dope", "zippa zappa zoobies i like boobies"};

		/**
		 * The constructor.
		 * 
		 * @param string theAnswer
		 */
		public Answer(string theAnswer)
		{
			answer = theAnswer;
		}

		/**
		 * Find out if the answer is any of our known versions of NO.
		 * 
		 * @return bool
		 */
		public bool isNo()
		{
			foreach (string x in falseStatements){
				if (x.Equals (answer)) {
					return true;
				}
			}

			return false;
		}
		
		/**
		 * Find out if the answer is any of our known versions of YES.
		 * 
		 * @return bool
		 */
		public bool isYes()
		{
			foreach (string x in trueStatements){
				if (x.Equals (answer)) {
					return true;
				}
			}

			return false;
		}

		/**
		 * Find out if the answer is neither YES or NO.
		 * 
		 * @return bool
		 */
		public bool isUnknown()
		{
			if (!this.isYes () && !this.isNo ()) {
				return true;
			}
			return false;
		}
	}

//===============================KeyPress==========================\\
	class KeyPress
	{
		/**
		 * @var string
		 */
		private ConsoleKey keyPress;

		/**
		 * The constructor.
		 * 
		 * @param string theAnswer
		 */
		public KeyPress(ConsoleKey pressedKey)
		{
			keyPress = pressedKey;
		}
						
		public bool isSpace()
		{
			if (keyPress != ConsoleKey.Spacebar) {
				Console.Clear ();
				Console.WriteLine ("I asked you to press spacebar\ntry pressing that instead of " + keyPress);
				return false;
			} 
			return true;
		}

	}


}


//===========================KeyPressInt============================\\

