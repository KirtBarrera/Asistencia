using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1Asistencias.Vista
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes();
            frm.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocentes frm = new FrmDocentes();
            frm.Show();
        }

        private void cicloLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAniosLectivos frm = new FrmAniosLectivos();
            frm.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursos frm = new FrmCursos();   
            frm.Show();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurnos frm = new FrmTurnos();    
            frm.Show();
        }

        private void secionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSecciones frm = new FrmSecciones();  
            frm.Show();
        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatriculas frm = new FrmMatriculas();
            frm.Show();
        }

        private void asignarSeccionAEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeccionEstudiantes frm = new FrmSeccionEstudiantes();
            frm.Show();
        }
    }
}
