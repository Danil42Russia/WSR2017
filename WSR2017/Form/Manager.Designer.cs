using System;
using System.Windows.Forms;

namespace WSR2017
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public void Form_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Экран менеджера";
            this.Text = "Экран менеджера";
            this.Load += new EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.FormClosing += new FormClosingEventHandler(Form_Exit);
        }

        #endregion
    }
}