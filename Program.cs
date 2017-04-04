using System;

namespace UnicamMath
{
    class Program
    {
  
        static void Main(string[] args)
        {
            int i=0;
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");
           
            Console.Write("Inserisci la lunghezza del cateto piu' lungo (in centimetri): ");
            string cateto1Testuale = Console.ReadLine();
            

            Console.Write("Inserisci la lunghezza del cateto piu' corto (in centimetri): ");
            string cateto2Testuale = Console.ReadLine();
            while(i==0)
            {
            try{
            
            double C=double.Parse(cateto1Testuale);
            double C1=Math.Pow(C,2);
            double c=double.Parse(cateto2Testuale);
            double c1=Math.Pow(c,2);

            //controllo che il primo cateto sia più corto del secondo
            while(c>C || c<0 || C<0){
             Console.Write("Controlla che il primo cateto sia più lungo del secondo e che non siano negativi! Reinserisci bene i dati!");
             Console.Write("\n");
             Console.Write("Inserisci la lunghezza del cateto piu' lungo (in centimetri): ");
             cateto1Testuale = Console.ReadLine();
             C=double.Parse(cateto1Testuale);
             C1=Math.Pow(C,2);

            Console.Write("Inserisci la lunghezza del cateto piu' corto (in centimetri): ");
            cateto2Testuale = Console.ReadLine();
            c=double.Parse(cateto2Testuale);
            c1=Math.Pow(c,2);

            }
  
            //calcolo ipotenusa
            double ipotenusa = C1+c1;
            double ipotenusaRadice=Math.Sqrt(ipotenusa);
            double angolo1 = 90;
            double angolo2 = 0;
            double angolo3 = 0;
            double tanc=0;

            //ci calcoliamo la tangente di C/c
            tanc=C/c;

            //ci calcoliamo prima il radiante della tangente e in seguito gli angoli
            double radiante1=Math.Atan(tanc);
            angolo2=radiante1*(180/Math.PI);
            angolo3=angolo1-angolo2;

            string ipotenusaTesto=(ipotenusaRadice.ToString("N2"));
            Console.WriteLine($"L'ipotenusa misura: {ipotenusaTesto} centimetri ");
            
            string a1=(angolo1.ToString("N2"));
        
            string a2=(angolo2.ToString("N2"));
    
            string a3=(angolo3.ToString("N2"));
            
            Console.WriteLine($"I tre angoli interni misurano:\nangolo 1= {a1} gradi\nangolo 2= {a2} gradi\nangolo 3= {a3} gradi\n");

            Console.ReadKey();
            }catch(Exception exc){
             Console.Write("Non puoi inserire delle lettere, inserisci numeri");
             Console.Write("\n");
             Console.Write("Inserisci la lunghezza del cateto piu' lungo (in centimetri): ");
             cateto1Testuale = Console.ReadLine();
             Console.Write("Inserisci la lunghezza del cateto piu' corto (in centimetri): ");
             cateto2Testuale = Console.ReadLine();

            }
          }
        }
  
    }
}

