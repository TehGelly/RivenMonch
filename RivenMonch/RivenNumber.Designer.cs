
namespace RivenMonch
{
    partial class RivenNumber
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nmupVal = new System.Windows.Forms.NumericUpDown();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmupVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            this.SuspendLayout();
            // 
            // nmupVal
            // 
            this.nmupVal.Location = new System.Drawing.Point(3, 56);
            this.nmupVal.Maximum = new decimal(new int[] {
            -94967296,
            0,
            0,
            0});
            this.nmupVal.Name = "nmupVal";
            this.nmupVal.Size = new System.Drawing.Size(249, 23);
            this.nmupVal.TabIndex = 0;
            this.nmupVal.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(3, 3);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(45, 47);
            this.pbx1.TabIndex = 1;
            this.pbx1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(54, 3);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(45, 47);
            this.pbx2.TabIndex = 2;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(105, 3);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(45, 47);
            this.pbx3.TabIndex = 3;
            this.pbx3.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(156, 3);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(45, 47);
            this.pbx4.TabIndex = 4;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(207, 3);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(45, 47);
            this.pbx5.TabIndex = 5;
            this.pbx5.TabStop = false;
            // 
            // RivenNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.nmupVal);
            this.Name = "RivenNumber";
            this.Size = new System.Drawing.Size(257, 83);
            ((System.ComponentModel.ISupportInitialize)(this.nmupVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NumericUpDown nmupVal;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
    }
}
