using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2D_Render_Project
{
    public partial class frmVectors : Form
    {

        Graphics gTOP;
        Graphics gFront;
        Graphics gSide;
        Pen pen;
        public frmVectors()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnClickMe = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFront = new System.Windows.Forms.Panel();
            this.PNLside = new System.Windows.Forms.Panel();
            this.PNL3D = new System.Windows.Forms.Panel();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(933, 139);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(271, 67);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTop.Location = new System.Drawing.Point(85, 80);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(252, 158);
            this.pnlTop.TabIndex = 3;
            // 
            // pnlFront
            // 
            this.pnlFront.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFront.Location = new System.Drawing.Point(85, 244);
            this.pnlFront.Name = "pnlFront";
            this.pnlFront.Size = new System.Drawing.Size(252, 158);
            this.pnlFront.TabIndex = 4;
            // 
            // PNLside
            // 
            this.PNLside.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PNLside.Location = new System.Drawing.Point(343, 244);
            this.PNLside.Name = "PNLside";
            this.PNLside.Size = new System.Drawing.Size(252, 158);
            this.PNLside.TabIndex = 5;
            // 
            // PNL3D
            // 
            this.PNL3D.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PNL3D.Location = new System.Drawing.Point(343, 80);
            this.PNL3D.Name = "PNL3D";
            this.PNL3D.Size = new System.Drawing.Size(252, 158);
            this.PNL3D.TabIndex = 6;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(945, 80);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(243, 22);
            this.txtTest.TabIndex = 7;
            // 
            // frmVectors
            // 
            this.ClientSize = new System.Drawing.Size(1237, 462);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.PNL3D);
            this.Controls.Add(this.PNLside);
            this.Controls.Add(this.pnlFront);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnClickMe);
            this.Name = "frmVectors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gTOP = pnlTop.CreateGraphics();
            gFront = pnlFront.CreateGraphics();
            gSide = PNLside.CreateGraphics();

            pen = new Pen(Color.Blue);
        }



        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("May it be drawn");
            Point3D p1 = new Point3D(10, 70, 10);
            Point3D p2 = new Point3D(500, 10, 10);
            Point3D p3 = new Point3D(10, 10, 100);


            //TOP
            gTOP.DrawLine(pen, p1.getXYPoint(), p2.getXYPoint());
            gTOP.DrawLine(pen, p2.getXYPoint(), p3.getXYPoint());
            gTOP.DrawLine(pen, p1.getXYPoint(), p3.getXYPoint());

            //FRONT
            gFront.DrawLine(pen, p1.getZYPoint(), p2.getZYPoint());
            gFront.DrawLine(pen, p2.getZYPoint(), p3.getZYPoint());
            gFront.DrawLine(pen, p1.getZYPoint(), p3.getZYPoint());

            //SIDE
            gSide.DrawLine(pen, p1.getZXPoint(), p2.getZXPoint());
            gSide.DrawLine(pen, p2.getZXPoint(), p3.getZXPoint());
            gSide.DrawLine(pen, p1.getZXPoint(), p3.getZXPoint());

            txtTest.Text = Vector3D.anglescos(new Vector3D(1, 2, 3), new Vector3D(2, 3, 4)).ToString();
        }
    }
}