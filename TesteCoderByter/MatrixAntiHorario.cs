using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteESSPalindrome
{
    public static class MatrixAntiHorario
    {
        public static string VamosSeila(string[] listNumerosArray){
            var ListNumeros = new List<string>();
            var auxArray = new List<string[]>();
            foreach(var item in listNumerosArray)
            {
                auxArray.Add(item.Replace("[", "").Replace("]", "").Split(","));
            }
            var linhas = (auxArray.Count() - 1);
            var colunas = (auxArray.FirstOrDefault().Count() - 1);
            var tamanhoTotal = (linhas + 1) * (colunas + 1);
            int top = 0, bottom = linhas, esquerda = 0, direita = colunas;

            while(tamanhoTotal >= 0)
            {
                for (var i = esquerda; i <= direita; i++)
                {
                    ListNumeros.Add(auxArray[top][i].Trim());
                    tamanhoTotal--;
                }
                if(tamanhoTotal <= 0)
                    break;
                top++;

                for (var i = top; i <= bottom; i++)
                {
                    ListNumeros.Add(auxArray[i][direita].Trim());
                    tamanhoTotal--;
                }
                if (tamanhoTotal <= 0)
                    break;
                direita--;

                for (var i = direita; i >= esquerda; i--)
                {
                    ListNumeros.Add(auxArray[bottom][i].Trim());
                    tamanhoTotal--;
                }
                if (tamanhoTotal <= 0)
                    break;
                bottom--;

                for(var i= bottom; i>=top; i--)
                {
                    ListNumeros.Add(auxArray[i][esquerda]);
                    tamanhoTotal--;
                }
                if (tamanhoTotal <= 0)
                    break;
                esquerda++;
            }

            return String.Join(",", ListNumeros);
        }
    }
}
