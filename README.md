#Word Finder
###By Stewart Cole 7/1/2016

##Setup

*Assuming you are running on windows and you have mono and nancy installed.* (http://www.mono-project.com/docs/getting-started/install/windows/)
*Clone the repository at*
(https://github.com/CrucialGier/csharp_review2_word-finder.git)
*using the command git clone*
*Enter the files directory using the console and enter dnu restore and then dnx kestrel*
*Visit localhost:5004 in your web browser.*


##Specs

*The phrase we'll be searching should be received from the user and stored in it's own variable.*
  *Example: Input: User enters : Shut it down. Shut it down forever.;*
            *Output : string Phrase = "Shut it down. Shut it down forever.";*

*The word we'll be searching for should also be received from the user and stored in its own seperate variable*
  *Example: Input: User enters : down;*
            *Output: string Word = "down";

*The stored phrase should be searched for an instance of the stored word and return that the word was found in the phrase"
  *Example: Input: User Clicks "Find Word" button;
            Output: Page displays: "The phrase contains the chosen word";

*The stored phrase should be searched for any instances of the stored word and return the number of times the word appears in the phrase.*
  *Example: Input: User Clicks "Find Word" button;
            Output: Page displays: "The word 'down' appears 2 time(s) in your phrase";*

##Known Bugs

None at the moment

##Technologies Used

Atom
C#
Html
Nancy
Razor

##Copyright

Stewart Cole copyright(c) 7/8/2016
