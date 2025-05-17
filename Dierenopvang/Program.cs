// See https://aka.ms/new-console-template for more information

using Dierenopvang;

DierenOpvang shelter = new DierenOpvang("Fluttershy Health Inc");

Papegaai papegaai = new Papegaai("Test", 10, true);
Papegaai papegaai2 = new Papegaai("Test2", 10, false);
Hond hond1 = new Hond("Test3", 10, "terrier");
Kat kat1 = new Kat("Test4", 10, "Oranje");

shelter.RegistreerDier(papegaai);
shelter.RegistreerDier(papegaai2);
shelter.RegistreerDier(hond1);
shelter.RegistreerDier(kat1);

shelter.VoerControleUit();

Dierenarts jim = new Dierenarts("Jim");
jim.VoerCheckUit(papegaai);
shelter.VoerControleUit();
