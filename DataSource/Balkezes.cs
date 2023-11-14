using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek_concole.DataSource
{
    internal class Balkezes
    {

        string jatekosNeve;
        DateOnly elsoDatum;
        DateOnly utolsoDatum;
        int jatekosSulya;
        int jatekosMagassaga;

        public Balkezes(string jatekosNeve, DateOnly elsoDatum, DateOnly utolsoDatum, int jatekosSulya, int jatekosMagassaga)
        {
            this.jatekosNeve = jatekosNeve;
            this.elsoDatum = elsoDatum;
            this.utolsoDatum = utolsoDatum;
            this.jatekosSulya = jatekosSulya;
            this.jatekosMagassaga = jatekosMagassaga;
        }

        public string JatekosNeve { get => jatekosNeve; set => jatekosNeve = value; }
        public DateOnly ElsoDatum { get => elsoDatum; set => elsoDatum = value; }
        public DateOnly UtolsoDatum { get => utolsoDatum; set => utolsoDatum = value; }
        public int JatekosSulya { get => jatekosSulya; set => jatekosSulya = value; }
        public int JatekosMagassaga { get => jatekosMagassaga; set => jatekosMagassaga = value; }
    }
}
