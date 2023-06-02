using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

public static class Validacoes
{

    public static bool CalculoCpf (string cpf)
    {
        cpf = cpf.Replace(",", "");
        cpf = cpf.Replace("-", "");
        MessageBox.Show(cpf);
        char letra = cpf[0];//cria ua variavel char para pegar cada caracter do cpf (comeca no zero para poder pegar o primero caradter

        int soma = 0; //contador soma para fazer o calculo com mod
        int[] cpfreal = new int [11]; 

        if (cpf.Length == 11 )  //confere o tamnaho d cpf
        {
            for (int j = 0; j <= 10; j++) // acompanha cada posicao d array e convert cada psociao par int e armazena no array
            {
                 cpfreal[j] = Convert.ToInt32(cpf[j].ToString());
            }
            int j2 = 0; // sera uma variavel para acompanhar o crescimneto do array e ser uma referencia para a posicao do array para multiplicar pelo i do for
            for (int i = 10; i > 1; i--)
            {
                // se p cpf for 052654852**
                soma += cpfreal[j2] * i;
                j2++;

                /* ele vai fazer
                0 (j2 = 0) * 10 (i) // j2 = 1
                5 (j2 = 1) * 9 (i) // j2 = 2
                2 (j2 = 2) * 8 (i) // j2 = 3
                6 (j2 = 3) * 7 (i) // j2 = 4
                5 (j2 = 4) * 6 (i) // j2 = 5
                4 (j2 = 5) * 5 (i) // j2 = 6
                8 (j2 = 6) * 4 (i) // j2 = 7
                5 (j2 = 7) * 3 (i) // j2 = 8
                2 (j2 = 8) * 2 (i) // j2 = 9
                */
                
            }

            if ((soma % 11) < 2)
            {
                // 
                // 012345678910
                int digitoum = 0;
                if (digitoum != Convert.ToInt32(cpfreal[9].ToString()))
                {
                    return false;
                }
            }
            else
            {
                int digitoum = 11 - (soma % 11);
                if (digitoum != Convert.ToInt32(cpfreal[9].ToString()))
                {
                    return false;
                }
            }

            //hdvfhjfkdjkdjfdjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj

            soma = 0;
            cpfreal = new int[11];
            j2 = 0;

            for (int i = 11; i >= 2; i--)
            {
                soma += cpfreal[j2] * i;
                j2++;

                //ele vai repertit o ´rpfesso do orirmero for comsiodardo omsegundk digito verificador
            }


            
            if ((soma % 11) < 2)
            {
                int digitodois = 0;
                if (digitodois != Convert.ToInt32(cpfreal[10].ToString()))
                {
                    return false;
                }
            }
            else
            {
                int digitodois = 11 - (soma % 11);
                if (digitodois != Convert.ToInt32(cpfreal[10].ToString()))
                {
                    return false;
                }
            }

            return true;

        }
        else
        {
            return false;
        }
    }
}
