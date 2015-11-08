Code d'analyse d'une syllabe vietnamienne
=========================================

Project Structure:
* FsmParser
Permet de générer une partie de l'implémentation d'un automate à partir de son fichier .dot.
Sert à générer VietSyllableTransducer\VstPartial.cs à partir de VietPhon\Data\graph.dot.

* MCPhon
Permet d'extraire le contenu du champ MC (Middle Chinese) du fichier baxter.txt et de le renvoyer sous forme d'objet typé.

* VietPhon


* VietSyllableTransducer
Implémentation du transducer d'analyse d'une syllabe vietnamienne et point d'entrée pour la tester.

* YieldMachine
Classe de base pour l'implémentation d'un automate.