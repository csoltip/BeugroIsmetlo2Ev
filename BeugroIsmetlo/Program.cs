using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeugroIsmetlo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Java:
            ArrayList<Double> valosLista = new ArrayList<>(); */
            List<double> valosLista = new List<double>();

            /* Java
            valosLista.add(23.34);*/
            valosLista.Add(23.34);

            valosLista.Add(5.0);
            valosLista.Add(12.45);
            valosLista.Add(1234.3456);
            double pi = Math.PI;
            valosLista.Add(pi);
            valosLista.Add(Math.E);
            int egesz = 7;

            /* egészből valósra konvertálási lehetőségek
            //valosLista.Add(egesz*1.0);
            valosLista.Add((double)egesz);
            
            /* további konvertálási lehetőségek: */
            /* Java
            valosLista.add(Double.parseDouble(String.valueOf(egesz)));
            valosLista.add(Double.parseDouble(egesz+"")); */
            valosLista.Add(double.Parse(egesz + ""));

            int i; //mert több helyen is használjuk
            for (i = 0; i < valosLista.Count; i++)//nem ebben a sorban lesz deklarálva az i, hanem előtte
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                /* Java
                System.out.printf("%9.3f", valosLista.get(i)); */
                Console.Write($"{valosLista[i],9:N3}");
            }
            /* Java
            System.out.println(""); */
            Console.WriteLine("");

            /* ez "csak" az értéket adja meg, nem a legjobb */
            /* Java
            double max = valosLista.get(0); */
            double max = valosLista[0];

            /* Java
            for (i = 1; i < valosLista.size(); i++) */
            for (i = 1; i < valosLista.Count; i++)//korábban már deklaráltuk i-t, itt csak értéket kap
            {
                /* Java
                if (valosLista.get(i) > max) */
                if (valosLista[i] > max)
                {
                    /* Java
                    max = valosLista.get(i); */
                    max = valosLista[i];
                }
            }
            /* Java
            System.out.println("max érték: " + max);
            System.out.println("max :indexe ??"); */

            int maxInd = 0;
            /* Java
            for (int i = 1; i < valosLista.size(); i++) */
            for (i = 1; i < valosLista.Count; i++)//korábban már deklaráltuk i-t, itt csak értéket kap
            {
                /* Java
                if (valosLista.get(i) > valosLista.get(maxInd)) */
                if (valosLista[i] > valosLista[maxInd])
                {
                    maxInd = i;
                }
            }
            /* Java
            System.out.println("max érték: " + valosLista.get(maxInd));
            System.out.println("max index: " + maxInd);*/
            Console.WriteLine("max érték: " + valosLista[maxInd]);
            Console.WriteLine("max index: " + maxInd);

            /* eldöntés I.: van legalább 1 T tul. eleme a sorozatnak */
            i = 0;//korábban már deklaráltuk i-t, itt csak értéket kap

            /* Java
            int N = valosLista.size(); */
            int N = valosLista.Count;

            /* Java
            while (i < N && !(valosLista.get(i) > 100)) */
            while (i < N && !(valosLista[i] > 100))
            {
                i++;
            }
            /* Java
            boolean van = i < N; */
            bool van = i < N;

            /* Java
            String ki = van ? "van" : "nincs";
            System.out.printf("van benne > 100: %s\n", ki);*/
            string ki = van ? "van" : "nincs";
            Console.WriteLine($"van benne > 100: {ki}");

            /* eldöntés II.: a sorozat MINDEN eleme T tul. ? */
            i = 0;

            /* Java
            N = valosLista.size(); */
            N = valosLista.Count;

            /* Java
            while (i < N && (valosLista.get(i) > 3)) */
            while (i < N && (valosLista[i] > 3))
            {
                i++;
            }

            /* Java
            boolean mind = i >= N; */
            bool mind = i >= N;
            ki = mind ? "igen" : "nem";
            Console.WriteLine($"minden elem > 100: {ki}");

            /* növekvő sorba van rendezve: */
            bool novekvo = novekvobeRendezett(valosLista);
            ki = novekvo ? "igen" : "nem";
            Console.WriteLine($"növekvő sorba van rendezve: {ki}");

            valosLista.Sort();//gyári rendező algoritmus
            ki = novekvobeRendezett(valosLista) ? "igen" : "nem";
            Console.WriteLine($"növekvő sorba van rendezve: {ki}");

            Console.ReadLine();
        }

        static bool novekvobeRendezett(List<double> lista)
        {
            bool novekvo;
            int i = 0, N = lista.Count;
            while (i < N - 1 && lista[i] < lista[i + 1])
            {
                i++;
            }
            novekvo = i >= N - 1;
            return novekvo;
        }
    }
}
