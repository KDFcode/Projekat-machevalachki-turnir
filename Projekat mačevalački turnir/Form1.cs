using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_mačevalački_turnir
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        //nemoj ovako svakako
        //prodji sve radiobuttone u jednom,pa drugom groupbox-u
        //pa checbkox po istom onom foreach principu
        //izbaci error ako nije sve pri ,,potvrdi''
        // onaj ,,pomocnik;; ako predje preko necega da ti kaze sta treba i kako
        //otkazi sve brise,fokus nazad na prvo polje
        //povezi s bazom
        //pri potvrdi unos svega u bazu,od teksta do box-ova
        //dodaj nesto za pregled toga kao ovo s kraja liste strana
        // zbirka
        // str 35 primer koristi
        //str 46&co primer koristi
        //str 76 takodje
        //str 84
        //str 101
        //str 123

        /*
        i ispitni zadaci
                private void rbLongsword_CheckedChanged(object sender, EventArgs e)
                {
                    if rbLongsword; ///zasto ga ne prepoznaje?

                }
        */
    }
}
