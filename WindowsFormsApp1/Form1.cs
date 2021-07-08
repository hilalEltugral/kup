using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Tao Gl kütüphaneleri
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float rotX = 0;
        float rotY = 0;
        float rotZ = 0;
        
 
        public Form1()
        {
            InitializeComponent();
            OpenGlControl1.InitializeContexts();
            //OpenGl ilk işlemler
            Gl.glClearColor(0.0f, 0.0f, 0.5f, 0.0f);//ekrana siyah rengi veriyoruz silince
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-2.0, 2.0, -2.0, 2.0, -2.0, 2.0);//projeksiyon görüntüsü
            Gl.glMatrixMode(Gl.GL_MODELVIEW);//modele aktardık

            Gl.glEnable(Gl.GL_DEPTH_TEST);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        float[][] pt = {
        new float[]{-1,-1,-1},new float[]{-1,1,-1},
        new float[]{1,-1,-1},new float[]{1,1,-1},
        new float[]{-1,-1,1},new float[]{-1,1,1},
        new float[]{1,-1,1},new float[]{1,1,1}

        };
        public void quad(int n1,int n2,int n3,int n4)
        {
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glColor3fv(pt[n1]); Gl.glVertex3fv(pt[n1]);
                Gl.glColor3fv(pt[n2]); Gl.glVertex3fv(pt[n2]);
                Gl.glColor3fv(pt[n3]); Gl.glVertex3fv(pt[n3]);
                Gl.glColor3fv(pt[n4]); Gl.glVertex3fv(pt[n4]);
            Gl.glEnd();
        }
        public void cube()
        {
            quad(6, 2, 3, 7); quad(5, 1, 0, 4);
            quad(7, 3, 1, 5); quad(4, 0, 2, 6);
            quad(2, 0, 1, 3); quad(7, 5, 4, 6);
        }
        private void OpenGlControl1_Paint(object sender, PaintEventArgs e)
        {         
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH);

            Gl.glPushMatrix();
                Gl.glRotatef(rotX, 1, 0, 0);
                Gl.glRotatef(rotY, 0, 1, 0);
                Gl.glRotatef(rotZ, 0, 0, 1);
                cube();
            Gl.glPopMatrix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              timer1.Start();
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            rotX = (rotX + 5) % 360;
            //  OpenGlControl1.Refresh();
            rotY = (rotY + 5) % 360;
            // OpenGlControl1.Refresh();
            rotZ = (rotZ + 5) % 360;
            OpenGlControl1.Refresh();
        }
    }
}
