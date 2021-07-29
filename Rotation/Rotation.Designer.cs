
namespace Rotation
{
    partial class Rotation
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.axisX = new System.Windows.Forms.NumericUpDown();
            this.axisY = new System.Windows.Forms.NumericUpDown();
            this.axisZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axisX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisZ)).BeginInit();
            this.SuspendLayout();
            // 
            // axisX
            // 
            this.axisX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.axisX.Location = new System.Drawing.Point(46, 30);
            this.axisX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.axisX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.axisX.Name = "axisX";
            this.axisX.Size = new System.Drawing.Size(120, 29);
            this.axisX.TabIndex = 0;
            this.axisX.ValueChanged += new System.EventHandler(this.axisX_ValueChanged);
            // 
            // axisY
            // 
            this.axisY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.axisY.Location = new System.Drawing.Point(46, 65);
            this.axisY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.axisY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.axisY.Name = "axisY";
            this.axisY.Size = new System.Drawing.Size(120, 29);
            this.axisY.TabIndex = 1;
            this.axisY.ValueChanged += new System.EventHandler(this.axisY_ValueChanged);
            // 
            // axisZ
            // 
            this.axisZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisZ.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.axisZ.Location = new System.Drawing.Point(46, 100);
            this.axisZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.axisZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.axisZ.Name = "axisZ";
            this.axisZ.Size = new System.Drawing.Size(120, 29);
            this.axisZ.TabIndex = 2;
            this.axisZ.ValueChanged += new System.EventHandler(this.axisZ_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // Rotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axisZ);
            this.Controls.Add(this.axisY);
            this.Controls.Add(this.axisX);
            this.Name = "Rotation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axisX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown axisX;
        private System.Windows.Forms.NumericUpDown axisY;
        private System.Windows.Forms.NumericUpDown axisZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

