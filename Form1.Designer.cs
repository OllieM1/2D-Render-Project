using System.Windows.Forms;

namespace _2D_Render_Project
{
    partial class frmVectors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button btnClickMe;
        private Panel pnlTop;
        private Panel pnlFront;
        private Panel PNLside;
        private Panel PNL3D;
        private TextBox txtTest;
    }
}

