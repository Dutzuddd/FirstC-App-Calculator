using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFRANCIOG_T1
{
    
    public partial class Form1 : Form
    {
        //Declaratiile datelor de care e nevoie, 2 numere intregi, 2 reale ( unul ptr rezultat si unul ptr calculul factorialului
        int num1, num2;
        Double rezultat, rezultatFactorial=1;
        String operatie = "";
                
        public Form1()
        {
            InitializeComponent();
        }

        //Functie / eveniment pentru butonul C ( care sterge valorile variabilelor ) 
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            operatie = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Functie/eveniment ptr butoanele de operatii ( inafara de factorial x! )
        private void operatia(object sender, EventArgs e)
        {
            Button b = sender as Button;
            operatie = b.Text;
            num1 = int.Parse(txtDisplay.Text) ;
            txtDisplay.Text = "0";
        }
        //Functie/eveniment ptr butonul =, care verifica ce operatie este, o realizeaza si afiseaza rezultatul in txtBox
        private void btnEgal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text) ;
            if (operatie == "+")
            {
                rezultat = num1 + num2;
            }
            else if ( operatie == "-")
            {
                rezultat = num1 - num2;
            }
            else if (operatie == "*")
            {
                rezultat = num1 * num2;
            }
            else if (operatie == "/")
            {
                rezultat = num1 / num2;
            }
            else if ( operatie == "%")
            {
                rezultat = num1 % num2 ;
            }
           
            txtDisplay.Text = rezultat.ToString();
        }

        //Functie/eveniment pentru calculul factorialului
        private void factorial(object sender, EventArgs e)
        {                        
            num1 = int.Parse(txtDisplay.Text);
            if( num1 <= 0 )
            {
                rezultatFactorial = 0;
            }
            else if ( num1 == 1 )
            {
                rezultatFactorial = 1;
            }
            else
                for( int i = 1; i <= num1; i++ )
                {
                    rezultatFactorial = rezultatFactorial * i;
                }
            txtDisplay.Text = rezultatFactorial.ToString();
        }

        //Functie/eveniment ptr butonul de "backspace"
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if ( txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

       //Functie/eveniment pentru cifrele calculatorului

        private void valoareaNumerica(object sender, EventArgs e)
        {
            Button b = (Button)sender;
                
            if (txtDisplay.Text == "0")
                txtDisplay.Text =  b.Text;
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            
        }
        
    }
}
