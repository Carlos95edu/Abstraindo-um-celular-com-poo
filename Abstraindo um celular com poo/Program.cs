using DesafioPOO.Models;

Smartphone nokia = new Nokia("9 1234-5678", "3220","1548+8" , 16);
Smartphone iphone = new Iphone("9 7890-1234","Iphone 11","asfg78",64);


nokia.Ligar();
nokia.InstalarAplicativo("Snake");
nokia.ExibirNumero();
nokia.Numero= "9 7894-5612";
nokia.ExibirNumero();

iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();