Code d'analyse d'une syllabe vietnamienne
=========================================

Project Structure:
* FsmParser
Permet de g�n�rer une partie de l'impl�mentation d'un automate � partir de son fichier .dot.
Sert � g�n�rer VietSyllableTransducer\VstPartial.cs � partir de VietPhon\Data\graph.dot.

* MCPhon
Permet d'extraire le contenu du champ MC (Middle Chinese) du fichier baxter.txt et de le renvoyer sous forme d'objet typ�.

* VietPhon


* VietSyllableTransducer
Impl�mentation du transducer d'analyse d'une syllabe vietnamienne et point d'entr�e pour la tester.

* YieldMachine
Classe de base pour l'impl�mentation d'un automate.