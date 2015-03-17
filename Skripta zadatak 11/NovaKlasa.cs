using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skripta_zadatak_11
{
    class NovaKlasa
    {

     internal int getUppers(string a)
        {
            int brojac = 0;
            foreach (char c in a)
            {
                if (char.IsUpper(c))
                {
                    brojac++;
                }
            }
            return brojac;
        }

   
     
    internal void Logika(string a,string b,Form1 form1, int brojac)
    {

            if (a != b)
            {
                form1.button1.Text = "Razlicite";
            }
            else if (a.Length < 5)
            {
                form1.button1.Text = "< 5";
            }
            else if (brojac < 3)
            {
                form1.button1.Text = "<3 velika";
            }
            else if (!a.Contains('#') && !a.Contains('$') && !a.Contains('%'))
            {
                form1.button1.Text = "nema retardiranih";
            }
            else
            {
                form1.pictureBox1.Show();
                form1.button1.Text = "5 bani buraz";

            }
    
    }
    
    }
    }

